using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class formPhongBan : Form
    {
        public formPhongBan()
        {
            InitializeComponent();
        }

        private void formPhongBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain frmnv = new formMain();
            frmnv.Show();
            this.Hide();
        }
    }
}
