using Band.ManageApp.Services;
using Band.ViewModels.Catalog.LoaiVe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Band.ManageApp
{
    public partial class ShowsUserControl : UserControl
    {
        public static ShowsUserControl _instance;
        private ShowsApiClient _showsApiClient;
        private List<LoaiVeViewModel> _dsLoaiVe; 
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
            _showsApiClient = new ShowsApiClient();
            _dsLoaiVe = new List<LoaiVeViewModel>();
            _dsLoaiVe = loadLoaiVe();
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
            loadDataGridView();
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
    }
}
