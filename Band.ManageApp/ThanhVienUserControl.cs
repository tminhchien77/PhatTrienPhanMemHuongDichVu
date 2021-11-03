using Band.Data.Entities;
using Band.ManageApp.Services;
using Band.ViewModels.Catalog.ThanhVien;
using Band.ViewModels.Catalog.VaiTro;
using Band.ViewModels.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using static Band.ViewModels.Utilities.SystemConstants;

namespace Band.ManageApp
{
    public partial class ThanhVienUserControl : UserControl
    {
        private ImageHandler imageHandler;
        public ThanhVienViewModel thanhVien;
        private ThanhVienApiClient _thanhVienApiClient;
        public static ThanhVienUserControl _instance;
        private List<Image> _avatarList;
        private List<Image> _coverList;
        private Image _avatar;
        private Image _cover;
        public event EventHandler AvatarChanged;
        public event EventHandler CoverChanged;
        public static ActionType _actionType;
/*        public static ImageType _imageType;
*/        public static List<ThanhVienViewModel> dsThanhVien { set; get; }
        protected virtual void OnAvatarChanged()
        {
            if (AvatarChanged != null) AvatarChanged(this, EventArgs.Empty);
        }
        protected virtual void OnCoverChanged()
        {
            if (CoverChanged != null) CoverChanged(this, EventArgs.Empty);
        }
        public Image avatar
        {
            get
            {
                return _avatar;
            }

            set
            {
                //#3
                _avatar = value;
                OnAvatarChanged();
            }
        }
        public Image cover
        {
            get
            {
                return _cover;
            }

            set
            {
                //#3
                _cover = value;
                OnCoverChanged();
            }
        }

        public static ThanhVienUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ThanhVienUserControl();
                }
                return _instance;
            }
        }
        public ThanhVienUserControl()
        {
            InitializeComponent();
            imageHandler = new ImageHandler();
            _actionType = ActionType.READ;
            dsThanhVien = new List<ThanhVienViewModel>();
            
            /*images = new NewListOfImage();
            images.Change += delegate (object sender, EventArgs arg)
            {
                if (images.Count() > 0) avatarImgBox.Image = images.First();
            };*/
            AvatarChanged += delegate (object sender, EventArgs arg)
            {
                avatarImgBox.Image = avatar;
            };
            CoverChanged += delegate (object sender, EventArgs arg)
            {
                coverImgBox.Image = cover;
            };

            loadDsThanhVien();
            /*loadDsVaiTro();*/
/*            bindingData();
*/            saveBtn.Visible = false;
            editAvatarBtn.Image= SetImageOpacity(editAvatarBtn.Image, 0.2f);
            editCoverImgBtn.Image = SetImageOpacity(editCoverImgBtn.Image, 0.2f);
            editVaiTroBtn.Image = SetImageOpacity(editVaiTroBtn.Image, 0.2f);
            avatarImgBox.Controls.Add(editAvatarBtn);
            editAvatarBtn.Location = new Point(avatarImgBox.Width - editAvatarBtn.Width - 5, avatarImgBox.Height - editAvatarBtn.Height - 5);
            
            
        }

        private void ThanhVienUserControl_Load(object sender, EventArgs e)
        {

        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            _avatarList = new NewListOfImage();
            _coverList = new NewListOfImage();
            avatarImgBox.Image = new Bitmap("C:\\Users\\mchie\\Desktop\\PhatTrienPhanMemHuongDichVu\\Band.ManageApp\\Resources\\user.png");
            coverImgBox.Image = new Bitmap("C:\\Users\\mchie\\Desktop\\PhatTrienPhanMemHuongDichVu\\Band.ManageApp\\Resources\\image.png");
            nameTxtBox.Text="";
            nationTxtBox.Text = "";
            stageNameTxtBox.Text = "";
            instaTxtBox.Text = "";
            twitterTxtBox.Text = "";
            storyTxtBox.Text = "";
            extraInfoTxtBox.Text = "";
            thanhVienCombobox.Visible = false;
            dsVaiTroLbl.Visible = false;
            
            loadDsVaiTro();
            saveBtn.Visible = true;
            _actionType = ActionType.CREATE;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _thanhVienApiClient = new ThanhVienApiClient();
            if (_actionType == ActionType.UPDATE)
            {
                ThanhVienGetAllViewModel tmp = thanhVienCombobox.SelectedValue as ThanhVienGetAllViewModel;
                var request = new ThanhVienUpdateRequestWithoutVaiTro()
                {
                    IdThanhVien = tmp.IdThanhVien,
                    DebutDate=debuteDateBox.Value,
                    Instagram=instaTxtBox.Text,
                    NgaySinh=dobBox.Value,
                    NgheDanh=stageNameTxtBox.Text,
                    QuocTich=nationTxtBox.Text,
                    TenKhaiSinh=nameTxtBox.Text,
                    TieuSu=storyTxtBox.Text,
                    Twitter=twitterTxtBox.Text
                };
                var response = _thanhVienApiClient.UpdateThanhVien(request);
                if (response)
                {
                    MessageBox.Show("Thành công!");
                    loadDsThanhVien();
                    thanhVienCombobox.SelectedIndex = thanhVienCombobox.FindStringExact(request.NgheDanh);
/*                    _ = _thanhVienApiClient.GetById(tmp.IdThanhVien);
*/                }
                else
                    MessageBox.Show("Thất bại!");
            }
            else if(_actionType == ActionType.CREATE)
            {
                if (avatar != null )
                {
                    List<byte[]> byteAvatarList = new List<byte[]>();
                    foreach (Image img in _avatarList)
                    {
                        byteAvatarList.Add(imageHandler.ImageToByteArray(img));
                    }
                    if (cover != null)
                    {
                        List<byte[]> byteCoverList = new List<byte[]>();
                        foreach (Image img in _coverList)
                        {
                            byteCoverList.Add(imageHandler.ImageToByteArray(img));
                        }
                        if (vaiTroListBox.CheckedItems != null && vaiTroListBox.CheckedItems.Count > 0)
                        {
                            List<int> dsIdVaiTro = new List<int>();
                            foreach (VaiTroViewModel x in vaiTroListBox.CheckedItems)
                            {
                                dsIdVaiTro.Add(x.IdVaiTro);
                            }
                            var request = new ThanhVienCreateRequest()
                            {
                                TenKhaiSinh = nameTxtBox.Text,
                                NgaySinh = dobBox.Value,
                                QuocTich = nationTxtBox.Text,
                                NgheDanh = stageNameTxtBox.Text,
                                DebutDate = debuteDateBox.Value,
                                Instagram = instaTxtBox.Text,
                                Twitter = twitterTxtBox.Text,
                                TieuSu = storyTxtBox.Text,
                                DsAvatar = byteAvatarList,
                                DsCover=byteCoverList,
                                DsIdVaiTro = dsIdVaiTro
                            };
                            if (checkForCorrectnessThanhVien(request))
                                if (_thanhVienApiClient.CreateThanhVien(request))
                                {
                                    MessageBox.Show("Thành công!");
                                }
                                else MessageBox.Show("Thất bại!");
                            saveBtn.Visible = false;
                            vaiTroListBox.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                            vaiTroListBox.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng thêm ảnh!");
                        editAvatarBtn.Focus();
                        return;
                    }                 
                }
                else
                {
                    MessageBox.Show("Vui lòng thêm ảnh!");
                    editAvatarBtn.Focus();
                    return;
                }    
            }
        }
        public static Image SetImageOpacity(Image image, float opacity)
        {
            Image tmpImage = image;
            try
            {
                //create a Bitmap the size of the image provided  
                Bitmap bmp = new Bitmap(tmpImage.Width, tmpImage.Height);

                //create a graphics object from the image  
                using (Graphics gfx = Graphics.FromImage(bmp))
                {

                    //create a color matrix object  
                    ColorMatrix matrix = new ColorMatrix();

                    //set the opacity  
                    matrix.Matrix33 = opacity;

                    //create image attributes  
                    ImageAttributes attributes = new ImageAttributes();

                    //set the color(opacity) of the image  
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    //now draw the image  
                    gfx.DrawImage(tmpImage, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, tmpImage.Width, tmpImage.Height, GraphicsUnit.Pixel, attributes);
                }
                return bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void editAvatarBtn_Click(object sender, EventArgs e)
        {
            var thanhVienGetAllVm = new ThanhVienGetAllViewModel();
            thanhVienGetAllVm = thanhVienCombobox.SelectedValue as ThanhVienGetAllViewModel;
            using (var imagesForm = new ImagesForm())
            {
                if (_actionType != ActionType.CREATE)
                    imagesForm.SenderInfo(ImageType.AVATAR_MEM, thanhVienGetAllVm.IdThanhVien);
                else
                    imagesForm.SenderInfo(ImageType.AVATAR_MEM);
                /*            imagesForm.ShowDialog();*/
                imagesForm.ShowDialog();
                avatar = imagesForm._images.FirstOrDefault().Anh;
                if (_actionType == ActionType.CREATE && _avatarList != null)
                    _avatarList.Clear();
                foreach (var x in imagesForm._images)
                {
                    _avatarList.Add(x.Anh);
                }
                /*if (imagesForm.ShowDialog() == DialogResult.OK)
                {
                    avatar = imagesForm._images.FirstOrDefault().Anh;
                    if (_actionType == ActionType.CREATE && _avatarList != null)
                        _avatarList.Clear();
                    foreach (var x in imagesForm._images)
                    {
                        _avatarList.Add(x.Anh);
                    }
                };*/
            }

            /*imagesForm.Sender(images);*/
            
            /*            imagesForm.Parent = this;*/
        }

        private void editAvatarBtn_MouseHover(object sender, EventArgs e)
        {
            editAvatarBtn.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void editAvatarBtn_MouseLeave(object sender, EventArgs e)
        {
            editAvatarBtn.BackColor = Color.FromArgb(0, Color.Black);
        }
        private void loadDsThanhVien()
        {
            _thanhVienApiClient = new ThanhVienApiClient();
            thanhVienCombobox.DataSource = _thanhVienApiClient.GetAll();
            thanhVienCombobox.DisplayMember = "NgheDanh";
        }
        private void loadDsVaiTro()
        {
            var dsVaiTro = _thanhVienApiClient.GetAllVaiTro();
            foreach(var x in dsVaiTro)
            {
                vaiTroListBox.Items.Add(x);
            }
            vaiTroListBox.Visible = true;
        }
/*        void bindingData()
        {
            nameTxtBox.DataBindings.Add(new Binding("Text", thanhVienCombobox.DataSource, "TenKhaiSinh"));
            dobBox.DataBindings.Add(new Binding("Value", thanhVienCombobox.DataSource, "NgaySinh"));
            nationTxtBox.DataBindings.Add(new Binding("Text", thanhVienCombobox.DataSource, "QuocTich"));
            stageNameTxtBox.DataBindings.Add(new Binding("Text", thanhVienCombobox.DataSource, "NgheDanh"));
            debuteDateBox.DataBindings.Add(new Binding("Value", thanhVienCombobox.DataSource, "DebutDate"));
            instaTxtBox.DataBindings.Add(new Binding("Text", thanhVienCombobox.DataSource, "Instagram"));
            twitterTxtBox.DataBindings.Add(new Binding("Text", thanhVienCombobox.DataSource, "Twitter"));
            storyTxtBox.DataBindings.Add(new Binding("Text", thanhVienCombobox.DataSource, "Tieusu"));
        }*/

        private void thanhVienCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                thanhVien = new ThanhVienViewModel();
                //Binding cho avatar
                ThanhVienGetAllViewModel tmp = cb.SelectedValue as ThanhVienGetAllViewModel;

                thanhVien = _thanhVienApiClient.GetById(tmp.IdThanhVien);
                

                /*images.Clear();
                foreach(var x in thanhVien.DsHinhAnh)
                {
                    var hinhAnh = imageConverter.ConvertFrom(x);
                    images.Add((Image)hinhAnh);
                }*/
                var byteAvatar = imageHandler._imageConverter.ConvertFrom(thanhVien.Avatar);
                avatar = (Image)byteAvatar;
                if (thanhVien.Cover != null)
                {
                    var byteCover = imageHandler._imageConverter.ConvertFrom(thanhVien.Cover);
                    cover = (Image)byteCover;
                }
                else cover = coverImgBox.ErrorImage;
                
                /*                var x1 = images.Count;
                *//*                avatarImgBox.Image = images.First();
                */                //Binding cho vai trò
                foreach (var x in thanhVien.DsVaiTro)
                {
                    dsVaiTroLbl.Text += (dsVaiTroLbl.Text == "" ? "" : ",") + x.TenVaiTro;
                }

                //Binding
                nameTxtBox.Text = thanhVien.TenKhaiSinh;
                dobBox.Value = thanhVien.NgaySinh;
                nationTxtBox.Text = thanhVien.QuocTich;
                stageNameTxtBox.Text = thanhVien.NgheDanh;
                debuteDateBox.Value = thanhVien.DebutDate;
                instaTxtBox.Text = thanhVien.Instagram;
                twitterTxtBox.Text = thanhVien.Twitter;
                storyTxtBox.Text = thanhVien.TieuSu;
            }
        }

/*        private void addHandlers()
        {
            foreach (TextBox control in infoPnl.Controls.OfType<TextBox>())
            {
                control.TextChanged += new EventHandler(OnContentChanged);
            }
            foreach (ComboBox control in infoPnl.Controls.OfType<ComboBox>())
            {
                control.SelectedIndexChanged += new EventHandler(OnContentChanged);
            }
            foreach (DateTimePicker control in infoPnl.Controls.OfType<DateTimePicker>())
            {
                control.ValueChanged += new EventHandler(OnContentChanged);
            }
            dsVaiTroLbl.TextChanged += new EventHandler(OnContentChanged);
            storyTxtBox.TextChanged += new EventHandler(OnContentChanged);
        }
        protected void OnContentChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null) saveBtn.Visible = true;
            
        }*/

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!nameTxtBox.Focused) return;
            if (!saveBtn.Visible) 
            {
                saveBtn.Visible = true;
                _actionType = ActionType.UPDATE;
            }
        }

        private void dobBox_ValueChanged(object sender, EventArgs e)
        {
            if (!dobBox.Focused) return;
            if (!saveBtn.Visible)
            {
                saveBtn.Visible = true;
                _actionType = ActionType.UPDATE;
            }
        }

        private void nationTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!nationTxtBox.Focused) return;
            if (!saveBtn.Visible)
            {
                saveBtn.Visible = true;
                _actionType = ActionType.UPDATE;
            }
        }

        private void stageNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!stageNameTxtBox.Focused) return;
            if (!saveBtn.Visible)
            {
                saveBtn.Visible = true;
                _actionType = ActionType.UPDATE;
            }
        }

        private void debuteDateBox_ValueChanged(object sender, EventArgs e)
        {
            if (!debuteDateBox.Focused) return;
            if (!saveBtn.Visible)
            {
                saveBtn.Visible = true;
                _actionType = ActionType.UPDATE;
            }
        }

        private void instaTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!instaTxtBox.Focused) return;
            if (!saveBtn.Visible)
            {
                saveBtn.Visible = true;
                _actionType = ActionType.UPDATE;
            }
        }

        private void twitterTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!twitterTxtBox.Focused) return;
            if (!saveBtn.Visible)
            {
                saveBtn.Visible = true;
                _actionType = ActionType.UPDATE;
            }
        }

        private void storyTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!storyTxtBox.Focused) return;
            if (!saveBtn.Visible)
            {
                saveBtn.Visible = true;
                _actionType = ActionType.UPDATE;
            }
        }

        private void editVaiTroBtn_Click(object sender, EventArgs e)
        {
            loadDsVaiTro();
            var dsTenVaiTro = new List<string>();
            foreach(var x in thanhVien.DsVaiTro)
            {
                dsTenVaiTro.Add(x.TenVaiTro);
            }
            for (int i = 0; i < vaiTroListBox.Items.Count; i++)
            {
                if (dsTenVaiTro.Contains(vaiTroListBox.Items[i].ToString()))
                {
                    vaiTroListBox.SetItemChecked(i, true);
                }
            }
        }

        private bool checkForCorrectnessThanhVien(ThanhVienCreateRequest thanhVien)
        {
            
            if (String.IsNullOrEmpty(stageNameTxtBox.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                stageNameTxtBox.Focus();
                return false;
            }

            foreach (Control c in leftInfoPnl.Controls)
            {
                if (c is TextBox)
                {
                    if (String.IsNullOrEmpty(c.Text))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                        c.Focus();
                        return false;
                    }
                }
            }
            return true;
            /*if (nameTxtBox.Text.Length == 0 || nationTxtBox.Text.Length == 0 
                || stageNameTxtBox.Text.Length == 0 || thanhVien.DsAnh == null 
                || thanhVien.DsIdVaiTro == null) return false;
            return true;*/
        }

        private void thanhVienCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var thanhVienGetAllVm = new ThanhVienGetAllViewModel();
            thanhVienGetAllVm = thanhVienCombobox.SelectedValue as ThanhVienGetAllViewModel;
            if (MessageBox.Show($"Xoá tất cả thông tin có liên quan của {thanhVienGetAllVm.NgheDanh}",
                       "Xoá thành viên",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _thanhVienApiClient.Delete(thanhVienGetAllVm.IdThanhVien);
                loadDsThanhVien();
            }
        }

        private void editCoverImgBtn_Click(object sender, EventArgs e)
        {
            var thanhVienGetAllVm = new ThanhVienGetAllViewModel();
            thanhVienGetAllVm = thanhVienCombobox.SelectedValue as ThanhVienGetAllViewModel;
            ImagesForm imagesForm = new ImagesForm();
            /*imagesForm.Sender(images);*/
            if (_actionType != ActionType.CREATE)
                imagesForm.SenderInfo(ImageType.COVER_MEM, thanhVienGetAllVm.IdThanhVien);
            else
                imagesForm.SenderInfo(ImageType.COVER_MEM);
            imagesForm.ShowDialog();
            cover = imagesForm._images.FirstOrDefault().Anh;
            if (_actionType == ActionType.CREATE && _coverList != null)
                _coverList.Clear();
            foreach (var x in imagesForm._images)
            {
                _coverList.Add(x.Anh);
            }
            /*            imagesForm.ShowDialog();*/
        }

        private void editCoverImgBtn_MouseHover(object sender, EventArgs e)
        {
            editCoverImgBtn.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void editCoverImgBtn_MouseLeave(object sender, EventArgs e)
        {
            editAvatarBtn.BackColor = Color.FromArgb(0, Color.Black);
        }
    }
}
