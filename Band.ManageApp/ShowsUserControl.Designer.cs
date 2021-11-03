
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addShowBtn = new System.Windows.Forms.PictureBox();
            this.showsComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ticketsTbl = new System.Windows.Forms.DataGridView();
            this.tiketTypeCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ticketDetailsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.editCoverImgBtn);
            this.panel2.Controls.Add(this.showPictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 460);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dateTimePicker3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dateTimePicker4);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(7, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 222);
            this.panel3.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(131, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Thông tin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày mở bán vé";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.AllowDrop = true;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(256, 134);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(88, 23);
            this.dateTimePicker3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giờ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(106, 134);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(95, 23);
            this.dateTimePicker4.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 23);
            this.textBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa điểm";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AllowDrop = true;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(106, 92);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 23);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(256, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 23);
            this.dateTimePicker1.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 23);
            this.textBox1.TabIndex = 1;
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
            this.panel4.Controls.Add(this.ticketsTbl);
            this.panel4.Location = new System.Drawing.Point(370, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 327);
            this.panel4.TabIndex = 7;
            // 
            // ticketsTbl
            // 
            this.ticketsTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tiketTypeCol,
            this.ticketDetailsCol});
            this.ticketsTbl.Location = new System.Drawing.Point(13, 24);
            this.ticketsTbl.Name = "ticketsTbl";
            this.ticketsTbl.RowTemplate.Height = 25;
            this.ticketsTbl.Size = new System.Drawing.Size(351, 290);
            this.ticketsTbl.TabIndex = 0;
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
            this.ticketDetailsCol.HeaderText = "Chi tiết";
            this.ticketDetailsCol.Name = "ticketDetailsCol";
            // 
            // editCoverImgBtn
            // 
            this.editCoverImgBtn.BackColor = System.Drawing.Color.Transparent;
            this.editCoverImgBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.editCoverImgBtn.Image = ((System.Drawing.Image)(resources.GetObject("editCoverImgBtn.Image")));
            this.editCoverImgBtn.Location = new System.Drawing.Point(617, 91);
            this.editCoverImgBtn.Name = "editCoverImgBtn";
            this.editCoverImgBtn.Size = new System.Drawing.Size(27, 22);
            this.editCoverImgBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editCoverImgBtn.TabIndex = 5;
            this.editCoverImgBtn.TabStop = false;
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
            this.Size = new System.Drawing.Size(762, 494);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addShowBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView ticketsTbl;
        private System.Windows.Forms.DataGridViewComboBoxColumn TicketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketDetails;
        private System.Windows.Forms.DataGridViewComboBoxColumn tiketTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketDetailsCol;
    }
}
