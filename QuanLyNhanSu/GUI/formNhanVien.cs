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

        NhanVienDAO nvDAO = new NhanVienDAO();

        private void formNhanVien_Load(object sender, EventArgs e)
        {
            NVdgv.DataSource = nvDAO.GetAll();
            EditDataGridView();
            LoadComboboxPhongBan();
            //Help();
        }

        private void EditDataGridView()
        {
            NVdgv.Columns["IDNv"].HeaderText = "ID Nhân viên";
            NVdgv.Columns["TenNv"].HeaderText = "Tên Nhân viên";
            NVdgv.Columns["GioitinhNv"].HeaderText = "Giới tính";
            NVdgv.Columns["NgaysinhNv"].HeaderText = "Ngày sinh";
            NVdgv.Columns["DiachiNv"].HeaderText = "Địa chỉ";
            NVdgv.Columns["SdtNv"].HeaderText = "SĐT";
            NVdgv.Columns["LuongNV"].HeaderText = "Lương";
            NVdgv.Columns["PbNv"].HeaderText = "ID Phòng ban";
        }

        private void NVdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String maPb, gtinh;
            int row = e.RowIndex;
            if (row >= 0)
            {
                idLabel.Text = NVdgv.Rows[row].Cells[0].Value.ToString();
                tenTbox.Text = NVdgv.Rows[row].Cells[1].Value.ToString();
                gtinh = NVdgv.Rows[row].Cells[2].Value.ToString();
                if (gtinh == "Nam")
                {
                    namRb.Checked = true;
                }
                else
                {
                    nuRB.Checked = true;
                }
                ngaySinhDTP.Text = NVdgv.Rows[row].Cells[3].Value.ToString();
                diaChiTB.Text = NVdgv.Rows[row].Cells[4].Value.ToString();
                sdtTB.Text = NVdgv.Rows[row].Cells[5].Value.ToString();
                luongTB.Text = NVdgv.Rows[row].Cells[6].Value.ToString();
                maPb = NVdgv.Rows[row].Cells[7].Value.ToString();
                comboBox1.Text = nvDAO.selectPhongBan(maPb);
            }
        }

        private void LoadComboboxPhongBan()
        {
            comboBox1.DataSource = NhanVienDAO.Instance.GetListPhongBan();
            comboBox1.DisplayMember = "tenPB";
            comboBox1.ValueMember = "IDPB";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            idLabel.Text = "";
            tenTbox.Text = "";
            ngaySinhDTP.Value = DateTime.Now;
            diaChiTB.Text = "";
            sdtTB.Text = "";
            luongTB.Text = "";
            searchButton.Text = "";
            comboBox1.Text = "";
        }

        private void themButton_Click(object sender, EventArgs e)
        {
            string tenNV = tenTbox.Text;
            int idPB = -1;
            Int32.TryParse(comboBox1.SelectedValue.ToString(), out idPB);
            string gioiTinh = namRb.Checked ? "Nam" : "Nữ";
            DateTime ngaySinh;
            DateTime.TryParse(ngaySinhDTP.Text, out ngaySinh);
            string dc = diaChiTB.Text;
            string sdt = sdtTB.Text;
            int luong = -1;
            Int32.TryParse(luongTB.Text.ToString(), out luong);
            try
            {
                if (tenNV == "" || idPB == -1 || ngaySinh == null || dc ==""|| sdt=="" || luong==-1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
                NhanVienDAO.Instance.Insert(tenNV, gioiTinh, ngaySinh, dc, sdt, luong, idPB);
                MessageBox.Show("Thêm thành công!");
                NVdgv.DataSource = nvDAO.GetAll();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra!" + err.ToString());
                NVdgv.DataSource = nvDAO.GetAll();
            }
        }

        private void suaButton_Click(object sender, EventArgs e)
        {
            int idNV;
            Int32.TryParse(idLabel.Text.Trim(), out idNV);
            string tenNhanVien = tenTbox.Text.Trim();
            int idPB = -1;
            Int32.TryParse(comboBox1.SelectedValue.ToString(), out idPB);
            string gioiTinh = namRb.Checked ? "Nam" : "N?";
            DateTime ngaySinh;
            DateTime.TryParse(ngaySinhDTP.Text, out ngaySinh);
            string dc = diaChiTB.Text.Trim();
            string sdt = sdtTB.Text.Trim();
            int luong = -1;
            Int32.TryParse(luongTB.Text.ToString().Trim(), out luong);
            try
            {
                if (tenNhanVien == "" || idPB == -1 || ngaySinh == null || idNV == -1 || dc == "" || sdt == "" || luong == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
                NhanVienDAO.Instance.Update(idNV, tenNhanVien, gioiTinh, ngaySinh, dc, sdt, luong, idPB);
                MessageBox.Show("Sửa thành công!");
                NVdgv.DataSource = nvDAO.GetAll();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra!" + err.ToString());
                NVdgv.DataSource = nvDAO.GetAll();
            }
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            formMain frmnv = new formMain();
            frmnv.Show();
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void searchTB_KeyDown(object sender, KeyEventArgs e)
        {

        }
		
        private void Help()
        {
			
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            // isHelp = !isHelp;
            // MaximizeBox = !isHelp;
            // MinimizeBox = !isHelp;
        }
    }
}
