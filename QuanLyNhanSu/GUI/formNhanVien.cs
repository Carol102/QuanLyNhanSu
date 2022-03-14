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
    public partial class formNhanVien : Form
    {
        public formNhanVien()
        {
            InitializeComponent();
        }

        private void formNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain frmnv = new formMain();
            frmnv.Show();
            this.Hide();
        }
    }
}
