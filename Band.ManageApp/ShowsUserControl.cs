using Band.ManageApp.Services;
using Band.ViewModels.Catalog.LoaiVe;
using Band.ViewModels.Catalog.Show;
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
    public partial class ShowsUserControl : UserControl
    {
        public static ShowsUserControl _instance;
        private ShowApiClient _showsApiClient;
        private List<LoaiVeViewModel> _dsLoaiVe;
        public static ActionType _actionType;
        private List<Image> _imageList;
        private Image _image;
        public event EventHandler ImageChanged;
        public Image image
        {
            get
            {
                return _image;
            }

            set
            {
                //#3
                _image = value;
                OnImageChanged();
            }
        }
        protected virtual void OnImageChanged()
        {
            if (ImageChanged != null) ImageChanged(this, EventArgs.Empty);
        }

        public static ShowsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ShowsUserControl();
                }
                return _instance;
            }
        }
        public ShowsUserControl()
        {
            InitializeComponent();
            _showsApiClient = new ShowApiClient();
            _dsLoaiVe = new List<LoaiVeViewModel>();
            _actionType = ActionType.READ;
            _dsLoaiVe = loadLoaiVe();
            ImageChanged += delegate (object sender, EventArgs arg)
            {
                showPictureBox.Image = image;
            };
        }
        private void loadDsShow()
        {
            var listShow = _showsApiClient.GetAll();
            var dict = new Dictionary<int, string>();
            foreach (var x in listShow)
            {
                dict.Add(x.IdShow, x.NgayBieuDien + "\t" + x.TenShow);
            }

            showsComboBox.DataSource = dict;
            showsComboBox.DisplayMember = "Value";
            showsComboBox.ValueMember = "Key";
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
        private List<LoaiVeViewModel> loadLoaiVe()
        {
            return _showsApiClient.GetAllLoaiVe();
        }
        private void loadDataGridView()
        {
            /*nameTxtBox.DataBindings.Add(new Binding("Text", thanhVienCombobox.DataSource, "TenKhaiSinh"));*/
            /*var colTicketType = new DataGridViewComboBoxColumn
            {
                DataSource = loadLoaiVe(),
                HeaderText = "Loại vé",
                *//*                DataPropertyName = "InsurDetailz",
                *//*
                DisplayMember = "TenLoai",
                ValueMember = "IdLoaiVe",
            };
            var colTicketDetails = new DataGridViewComboBoxColumn
            ticketsTbl.Columns.Add(colTicketType);*/
            tiketTypeCol.DataSource = _dsLoaiVe;
            tiketTypeCol.DisplayMember = "TenLoai";
            tiketTypeCol.ValueMember = "IdLoaiVe";
            /*tiketTypeCol.ValueType*/
/*            ticketDetailsCol.DataPropertyName
*/
        }
        private void addShowBtn_Click(object sender, EventArgs e)
        {
            _imageList = new List<Image>();
            loadDataGridView();
            nameTxtBox.Text = "";
            locationTxtBox.Text = "";
            performDatebox.Value = DateTime.Today.AddDays(1);
            performTimeBox.Value = DateTime.Now;
            saleDateBox.Value = DateTime.Today;
            saleTimeBox.Value = DateTime.Now;
            detailTicketTxtBox.Text = "";
            saveBtn.Visible = true;
            _actionType = ActionType.CREATE;
        }

        private void ticketsTbl_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void ticketsTbl_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)ticketsTbl.Rows[e.RowIndex].Cells[0];
                string detail="";
                foreach(var x in _dsLoaiVe)
                {
                    if (x.IdLoaiVe == (int)cb.Value)
                    {
                        detail = x.ChiTiet;
                        break;
                    }
                }
                if (cb.Value != null)
                {
                    ticketsTbl.Rows[e.RowIndex].Cells[1].Value = detail;
                }
            }
            ticketsTbl.Invalidate();
            /*var newValue = ticketsTbl.CurrentCell.EditedFormattedValue;
            var tmp = (LoaiVeViewModel)newValue;
            ticketsTbl.Rows[e.RowIndex].Cells[1].Value = tmp.ChiTiet;*/
        }

        private void ticketsTbl_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (ticketsTbl.IsCurrentCellDirty)
            {
                ticketsTbl.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void ticketsTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void editCoverImgBtn_MouseHover(object sender, EventArgs e)
        {

        }

        private void addShowBtn_MouseHover(object sender, EventArgs e)
        {
            addShowBtn.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void addShowBtn_MouseLeave(object sender, EventArgs e)
        {
            addShowBtn.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        private void editCoverImgBtn_Click(object sender, EventArgs e)
        {
            /*var showGetAllVm = new ShowGetAllViewModel();
            showGetAllVm = showsComboBox.SelectedValue as ShowGetAllViewModel;*/
            ImagesForm imagesForm = new ImagesForm();
            if (_actionType != ActionType.CREATE)
                imagesForm.SenderInfo(ImageType.IMG_SHOW, (int)showsComboBox.SelectedValue);
            else
                imagesForm.SenderInfo(ImageType.IMG_SHOW);

            imagesForm.ShowDialog();
            image = imagesForm._images.FirstOrDefault().Anh;
            if (_actionType == ActionType.CREATE && _imageList != null)
                _imageList.Clear();
            foreach (var x in imagesForm._images)
            {
                _imageList.Add(x.Anh);
            }

            /*if (imagesForm.ShowDialog() == DialogResult.OK)
            {
                image = imagesForm._images.FirstOrDefault().Anh;
                if (_actionType == ActionType.CREATE && _imageList != null)
                    _imageList.Clear();
                foreach (var x in imagesForm._images)
                {
                    _imageList.Add(x.Anh);
                }
            };*/
        }
    }
}
