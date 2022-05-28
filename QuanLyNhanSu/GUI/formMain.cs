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

            Help();
        }
        private HelpProvider hlpProvider;
        bool isHelp = false;

        private void Help()
        {
            hlpProvider = new HelpProvider();

            hlpProvider.SetShowHelp(buttonNV, true);
            hlpProvider.SetHelpString(buttonNV, "Di den man hinh Quan ly Nhan Vien.");

            hlpProvider.SetShowHelp(buttonPB, true);
            hlpProvider.SetHelpString(buttonPB, "Di den man hinh Quan ly Phong Ban.");

            hlpProvider.SetShowHelp(NVlabel, true);
            hlpProvider.SetHelpString(NVlabel, "Tong so Nhan Vien.");

            hlpProvider.SetShowHelp(PBlabel, true);
            hlpProvider.SetHelpString(PBlabel, "Tong so Phong Ban.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isHelp = !isHelp;
            MaximizeBox = !isHelp;
            MinimizeBox = !isHelp;
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
