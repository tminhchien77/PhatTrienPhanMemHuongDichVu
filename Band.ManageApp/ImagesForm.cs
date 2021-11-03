using Band.ManageApp.Services;
using Band.ViewModels.Catalog.ThanhVien;
using Band.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Band.ViewModels.Utilities.SystemConstants;

namespace Band.ManageApp
{
    public partial class ImagesForm : Form
    {
        private ImageHandler _imageHandler;
        public NewListOfImage _images;
        private int _idObject;
        private ImageType _imgType;
        private int numOfImages;
        private ThanhVienApiClient _thanhVienApiClient;
        /*public delegate void SendImgList(ref NewListOfImage imgList);*/
        public delegate void SendId(ImageType imgeType, int id=-1);
        /*public SendImgList Sender;*/
        public SendId SenderId;
        public ImagesForm()
        {
            InitializeComponent();
            _imageHandler = new ImageHandler();
            _images = new NewListOfImage();
            /*Sender = new SendImgList(GetImgList);*/
            SenderId = new SendId(GetInfo);
            _images.Change += delegate (object sender, EventArgs arg)
            {
                if (_images.Count > 0) loadImages();
            };
           

            imgsContainer.VerticalScroll.Enabled = false;
            imgsContainer.VerticalScroll.Visible = false;
            imgsContainer.VerticalScroll.Maximum = 0;
            imgsContainer.AutoScroll = true;
        }
        /*private void GetImgList(ref NewListOfImage imgList)
        {
            foreach(var x in imgList)
            {
                _images.Add(x);
            }
        }*/
        private void GetInfo(ImageType imageType,int id= -1)
        {
            _idObject = id;
            _imgType = imageType;

            _thanhVienApiClient = new ThanhVienApiClient();
            if(_imgType == ImageType.AVATAR_MEM)
                foreach(var x in _thanhVienApiClient.GetAllAvatarById(id))
                {
                    _images.Add(new ImageObject(x));
                }
            else if (imageType == ImageType.COVER_MEM)
                foreach (var x in _thanhVienApiClient.GetAllCoverById(id))
                {
                    _images.Add(new ImageObject(x));
                }

            /*            _images.AddRange(_thanhVienApiClient.GetAllImgeById(id));
            */
        }
        private void addImgsBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.jpeg|All files|*.*";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                numOfImages = _images.Count;
                saveBtn.Visible = true;
                string[] files = openFileDialog.FileNames;
                foreach (string img in files)
                {
                    FlowLayoutPanel pnl = new FlowLayoutPanel();
                    pnl.Size = new Size(100, 150);
                    CheckBox checkBox = new CheckBox();
                    _images.Add(new ImageObject(Image.FromFile(img)));
                }
            }
            else saveBtn.Visible = false;
        }

        private void addImgsBtn_MouseHover(object sender, EventArgs e)
        {
            addImgsBtn.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void addImgsBtn_MouseLeave(object sender, EventArgs e)
        {
            addImgsBtn.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void removeImgsBtn_Click(object sender, EventArgs e)
        {
            foreach (Control p in imgsContainer.Controls)
                if (p is Panel)
                    foreach (Control c in p.Controls)
                        if (c is CheckBox)
                            c.Visible=true;
            selectAllCheckBox.Visible = true;
            deleteBtn.Visible = true;
        }
        private void loadImages()
        {
            imgsContainer.Controls.Clear();
            foreach (var imgObj in _images)
            {
                Panel pnl = new Panel();
                pnl.Margin = Padding.Empty;
                pnl.Size = new Size((imgsContainer.Width) / 3, (imgsContainer.Width) / 3);
                pnl.Padding = new Padding(3, 3, 3, 15);
                CheckBox checkBox = new CheckBox();
                checkBox.Dock = DockStyle.Top;
                checkBox.CheckAlign = ContentAlignment.MiddleCenter;
                checkBox.Visible = false;
                PictureBox pic = new PictureBox();
                pic.Dock = DockStyle.Fill;
                pic.Image = imgObj.Anh;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pnl.Controls.AddRange(new Control[] { pic, checkBox });
                imgsContainer.Controls.Add(pnl);
            }
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            List<byte[]> byteImgList = new List<byte[]>();
            for (int i =numOfImages; i < _images.Count; i++)
            {
                byteImgList.Add(_images[i].CovertToByteArray());
            }
            if (_idObject!=-1)
            {
                HinhAnhThanhVienRequest request;
                if (_imgType == ImageType.AVATAR_MEM)
                {
                    request = new HinhAnhThanhVienRequest()
                    {
                        DsAnh = byteImgList,
                        IdThanhVien = _idObject,
                        IdLoai= (int)ImageType.AVATAR_MEM
                    };
                }
                else
                {
                    request = new HinhAnhThanhVienRequest()
                    {
                        DsAnh = byteImgList,
                        IdThanhVien = _idObject,
                        IdLoai = (int)ImageType.COVER_MEM
                    };
                }
                if (_thanhVienApiClient.AddingImages(request)) MessageBox.Show("Thành công!");
                else MessageBox.Show("Thất bại!");
            }
            saveBtn.Visible = false;


        }

        private void ImagesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saveBtn.Visible)
            {
                if (MessageBox.Show("Thoát và không lưu?",
                       "Chưa lưu thay đổi",
                        MessageBoxButtons.YesNo) == DialogResult.No)    e.Cancel = true;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            var listId = new List<int>();
            foreach (var p in imgsContainer.Controls.OfType<Panel>())
            {
                if (((CheckBox)p.Controls.OfType<CheckBox>().FirstOrDefault()).Checked)
                {
                    var img = ((PictureBox)p.Controls.OfType<PictureBox>().FirstOrDefault());
                    listId.Add(_images[i].IdAnh.Value);
                    _images.RemoveAt(i);  
                }
                i++;
            }
            if(_idObject!=-1)
            {
                if (_thanhVienApiClient == null)
                    _thanhVienApiClient = new ThanhVienApiClient();
                _thanhVienApiClient.DeleteImages(listId);
            }
                   
            deleteBtn.Visible = false;
            selectAllCheckBox.Visible = false;
        }
    }
}
