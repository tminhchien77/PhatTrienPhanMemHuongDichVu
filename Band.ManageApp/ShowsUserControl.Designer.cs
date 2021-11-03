
namespace Band.ManageApp
{
    partial class ShowsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowsUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addShowBtn = new System.Windows.Forms.PictureBox();
            this.showsComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.locationTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.performDatebox = new System.Windows.Forms.DateTimePicker();
            this.performTimeBox = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totalPrice = new System.Windows.Forms.Label();
            this.totalTickets = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.detailTicketTxtBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ticketsTbl = new System.Windows.Forms.DataGridView();
            this.tiketTypeCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ticketDetailsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceTicketCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityTicketCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleTimeBox = new System.Windows.Forms.DateTimePicker();
            this.saleDateBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.editCoverImgBtn = new System.Windows.Forms.PictureBox();
            this.showPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addShowBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editCoverImgBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addShowBtn);
            this.panel1.Controls.Add(this.showsComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 34);
            this.panel1.TabIndex = 0;
            // 
            // addShowBtn
            // 
            this.addShowBtn.ErrorImage = null;
            this.addShowBtn.Image = ((System.Drawing.Image)(resources.GetObject("addShowBtn.Image")));
            this.addShowBtn.Location = new System.Drawing.Point(160, 3);
            this.addShowBtn.Name = "addShowBtn";
            this.addShowBtn.Size = new System.Drawing.Size(27, 27);
            this.addShowBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addShowBtn.TabIndex = 6;
            this.addShowBtn.TabStop = false;
            this.addShowBtn.Click += new System.EventHandler(this.addShowBtn_Click);
            this.addShowBtn.MouseLeave += new System.EventHandler(this.addShowBtn_MouseLeave);
            this.addShowBtn.MouseHover += new System.EventHandler(this.addShowBtn_MouseHover);
            // 
            // showsComboBox
            // 
            this.showsComboBox.FormattingEnabled = true;
            this.showsComboBox.Location = new System.Drawing.Point(3, 5);
            this.showsComboBox.Name = "showsComboBox";
            this.showsComboBox.Size = new System.Drawing.Size(151, 23);
            this.showsComboBox.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.editCoverImgBtn);
            this.panel2.Controls.Add(this.showPictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 532);
            this.panel2.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(365, 494);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.locationTxtBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.performDatebox);
            this.panel3.Controls.Add(this.performTimeBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.nameTxtBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(7, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 122);
            this.panel3.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(358, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Thông tin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày biểu diễn";
            // 
            // locationTxtBox
            // 
            this.locationTxtBox.Location = new System.Drawing.Point(502, 55);
            this.locationTxtBox.Name = "locationTxtBox";
            this.locationTxtBox.Size = new System.Drawing.Size(238, 23);
            this.locationTxtBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa điểm";
            // 
            // performDatebox
            // 
            this.performDatebox.AllowDrop = true;
            this.performDatebox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.performDatebox.Location = new System.Drawing.Point(106, 92);
            this.performDatebox.Name = "performDatebox";
            this.performDatebox.Size = new System.Drawing.Size(95, 23);
            this.performDatebox.TabIndex = 5;
            this.performDatebox.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // performTimeBox
            // 
            this.performTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.performTimeBox.Location = new System.Drawing.Point(256, 92);
            this.performTimeBox.Name = "performTimeBox";
            this.performTimeBox.ShowUpDown = true;
            this.performTimeBox.Size = new System.Drawing.Size(88, 23);
            this.performTimeBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giờ";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(106, 52);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(238, 23);
            this.nameTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên show";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.totalPrice);
            this.panel4.Controls.Add(this.totalTickets);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.detailTicketTxtBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.ticketsTbl);
            this.panel4.Controls.Add(this.saleTimeBox);
            this.panel4.Controls.Add(this.saleDateBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(7, 258);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(752, 230);
            this.panel4.TabIndex = 7;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Location = new System.Drawing.Point(327, 203);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(0, 15);
            this.totalPrice.TabIndex = 17;
            // 
            // totalTickets
            // 
            this.totalTickets.AutoSize = true;
            this.totalTickets.Location = new System.Drawing.Point(225, 203);
            this.totalTickets.Name = "totalTickets";
            this.totalTickets.Size = new System.Drawing.Size(0, 15);
            this.totalTickets.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng cộng:";
            // 
            // detailTicketTxtBox
            // 
            this.detailTicketTxtBox.Location = new System.Drawing.Point(468, 82);
            this.detailTicketTxtBox.Name = "detailTicketTxtBox";
            this.detailTicketTxtBox.Size = new System.Drawing.Size(272, 107);
            this.detailTicketTxtBox.TabIndex = 15;
            this.detailTicketTxtBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Chi tiết vé";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(318, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Thông tin bán vé";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày mở bán vé";
            // 
            // ticketsTbl
            // 
            this.ticketsTbl.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ticketsTbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ticketsTbl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ticketsTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ticketsTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tiketTypeCol,
            this.ticketDetailsCol,
            this.priceTicketCol,
            this.quantityTicketCol});
            this.ticketsTbl.Location = new System.Drawing.Point(3, 82);
            this.ticketsTbl.MultiSelect = false;
            this.ticketsTbl.Name = "ticketsTbl";
            this.ticketsTbl.RowTemplate.Height = 25;
            this.ticketsTbl.Size = new System.Drawing.Size(414, 107);
            this.ticketsTbl.TabIndex = 0;
            this.ticketsTbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketsTbl_CellContentClick);
            this.ticketsTbl.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketsTbl_CellValueChanged);
            this.ticketsTbl.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.ticketsTbl_ColumnDisplayIndexChanged);
            this.ticketsTbl.CurrentCellDirtyStateChanged += new System.EventHandler(this.ticketsTbl_CurrentCellDirtyStateChanged);
            // 
            // tiketTypeCol
            // 
            this.tiketTypeCol.HeaderText = "Loại vé";
            this.tiketTypeCol.Name = "tiketTypeCol";
            // 
            // ticketDetailsCol
            // 
            this.ticketDetailsCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ticketDetailsCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.ticketDetailsCol.HeaderText = "Chi tiết";
            this.ticketDetailsCol.Name = "ticketDetailsCol";
            this.ticketDetailsCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // priceTicketCol
            // 
            this.priceTicketCol.HeaderText = "Giá";
            this.priceTicketCol.Name = "priceTicketCol";
            // 
            // quantityTicketCol
            // 
            this.quantityTicketCol.HeaderText = "Số lượng";
            this.quantityTicketCol.Name = "quantityTicketCol";
            // 
            // saleTimeBox
            // 
            this.saleTimeBox.AllowDrop = true;
            this.saleTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.saleTimeBox.Location = new System.Drawing.Point(256, 53);
            this.saleTimeBox.Name = "saleTimeBox";
            this.saleTimeBox.ShowUpDown = true;
            this.saleTimeBox.Size = new System.Drawing.Size(88, 23);
            this.saleTimeBox.TabIndex = 11;
            // 
            // saleDateBox
            // 
            this.saleDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.saleDateBox.Location = new System.Drawing.Point(106, 53);
            this.saleDateBox.Name = "saleDateBox";
            this.saleDateBox.Size = new System.Drawing.Size(95, 23);
            this.saleDateBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giờ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // editCoverImgBtn
            // 
            this.editCoverImgBtn.BackColor = System.Drawing.Color.Transparent;
            this.editCoverImgBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.editCoverImgBtn.Image = ((System.Drawing.Image)(resources.GetObject("editCoverImgBtn.Image")));
            this.editCoverImgBtn.Location = new System.Drawing.Point(720, 93);
            this.editCoverImgBtn.Name = "editCoverImgBtn";
            this.editCoverImgBtn.Size = new System.Drawing.Size(27, 22);
            this.editCoverImgBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editCoverImgBtn.TabIndex = 5;
            this.editCoverImgBtn.TabStop = false;
            this.editCoverImgBtn.Click += new System.EventHandler(this.editCoverImgBtn_Click);
            this.editCoverImgBtn.MouseHover += new System.EventHandler(this.editCoverImgBtn_MouseHover);
            // 
            // showPictureBox
            // 
            this.showPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.showPictureBox.Location = new System.Drawing.Point(0, 0);
            this.showPictureBox.Name = "showPictureBox";
            this.showPictureBox.Size = new System.Drawing.Size(762, 124);
            this.showPictureBox.TabIndex = 0;
            this.showPictureBox.TabStop = false;
            // 
            // ShowsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ShowsUserControl";
            this.Size = new System.Drawing.Size(762, 566);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addShowBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editCoverImgBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox addShowBtn;
        private System.Windows.Forms.ComboBox showsComboBox;
        private System.Windows.Forms.PictureBox showPictureBox;
        private System.Windows.Forms.PictureBox editCoverImgBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker saleTimeBox;
        private System.Windows.Forms.DateTimePicker saleDateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox locationTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker performDatebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker performTimeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView ticketsTbl;
        private System.Windows.Forms.DataGridViewComboBoxColumn TicketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketDetails;
        private System.Windows.Forms.DataGridViewComboBoxColumn tiketTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketDetailsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceTicketCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityTicketCol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label totalTickets;
        private System.Windows.Forms.RichTextBox detailTicketTxtBox;
        private System.Windows.Forms.Button saveBtn;
    }
}
