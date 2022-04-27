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

        private void backButton_Click(object sender, EventArgs e)
        {
            formMain frmnv = new formMain();
            frmnv.Show();
            this.Hide();
        }

        PhongBanDAO pbDAO = new PhongBanDAO();

        private void formPhongBan_Load(object sender, EventArgs e)
        {
            PBdgv.DataSource = pbDAO.GetAll();
            EditDataGridView();
            //Help();
        }

        private void EditDataGridView()
        {
            PBdgv.Columns["IDPB"].HeaderText = "ID Phòng Ban";
            PBdgv.Columns["IDPB"].Width = 130;
            PBdgv.Columns["TenPb"].HeaderText = "Tên Phòng Ban";
            PBdgv.Columns["TenPb"].Width = 200;
            PBdgv.Columns["SdtPb"].HeaderText = "SĐT";
            PBdgv.Columns["SdtPb"].Width = 200;
            PBdgv.Columns["MotaPb"].HeaderText = "Mô tả";
            PBdgv.Columns["MotaPb"].Width = 300;
        }

        private void PBdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                idLabel.Text = PBdgv.Rows[row].Cells[0].Value.ToString();
                tenPBTbox.Text = PBdgv.Rows[row].Cells[1].Value.ToString();
                sdtPbTB.Text = PBdgv.Rows[row].Cells[2].Value.ToString();
                moTaTB.Text = PBdgv.Rows[row].Cells[3].Value.ToString();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            idLabel.Text = "";
            tenPBTbox.Text = "";
            sdtPbTB.Text = "";
            moTaTB.Text = "";
        }

        private void themButton_Click(object sender, EventArgs e)
        {
            string tenPB = tenPBTbox.Text;
            string sdt = sdtPbTB.Text;
            string mota = moTaTB.Text;
            try
            {
                if (tenPB == "" || sdt == "" || mota == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
                PhongBanDAO.Instance.Insert(tenPB, sdt, mota);
                MessageBox.Show("Thêm thành công!");
                PBdgv.DataSource = pbDAO.GetAll();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra!" + err.ToString());
                PBdgv.DataSource = pbDAO.GetAll();
            }
        }

        private void suaButton_Click(object sender, EventArgs e)
        {

        }

        private void xoaButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void searchTB_KeyDown(object sender, KeyEventArgs e)
        {

        }
		
        private HelpProvider hlpProvider;
        bool isHelp = false;
		
        private void Help()
        {

        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }

    }
}
