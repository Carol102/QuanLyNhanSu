using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyNhanSu.DAO;

namespace QuanLyNhanSu.GUI
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            DataTable dt = null;
            String sql = "select count(*) from NhanVien";
            dt = DataAccess.Instance.ExecuteQuery(sql);
            NVlabel.Text= dt.Rows[0][0].ToString();

            DataTable dt1 = null;
            String sql1 = "select count(*) from PhongBan";
            dt1 = DataAccess.Instance.ExecuteQuery(sql1);
            PBlabel.Text = dt1.Rows[0][0].ToString();
        }

        private void buttonNV_Click(object sender, EventArgs e)
        {
            formNhanVien frmnv = new formNhanVien();
            frmnv.Show();
            this.Hide();
        }

        private void buttonPB_Click(object sender, EventArgs e)
        {
            formPhongBan frmnv = new formPhongBan();
            frmnv.Show();
            this.Hide();
        }
    }
}
