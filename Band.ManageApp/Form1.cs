using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Band.ManageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ThanhVienMenuItem_Click(object sender, EventArgs e)
        {
            if (!mainContainer.Controls.Contains(ThanhVienUserControl.Instance))
            {
                mainContainer.Controls.Add(ThanhVienUserControl.Instance);
                ThanhVienUserControl.Instance.Dock = DockStyle.Fill;
                ThanhVienUserControl.Instance.BringToFront();
            }
            ThanhVienUserControl.Instance.BringToFront();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!mainContainer.Controls.Contains(ShowsUserControl.Instance))
            {
                mainContainer.Controls.Add(ShowsUserControl.Instance);
                ShowsUserControl.Instance.Dock = DockStyle.Fill;
                ShowsUserControl.Instance.BringToFront();
            }
            ShowsUserControl.Instance.BringToFront();
        }
    }
}
