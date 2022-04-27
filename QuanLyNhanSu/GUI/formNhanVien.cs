using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyNhanSu.DAO;
using QuanLyNhanSu.DTO;


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
            Help();
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

        private HelpProvider hlpProvider;
        bool isHelp = false;

        private void Help()
        {
            hlpProvider = new HelpProvider();

            hlpProvider.SetShowHelp(backButton, true);
            hlpProvider.SetHelpString(backButton, "Tro ve man hinh truoc.");

            hlpProvider.SetShowHelp(tenTbox, true);
            hlpProvider.SetHelpString(tenTbox, "Nhap Ho Ten cua nhan vien.");

            hlpProvider.SetShowHelp(namRb, true);
            hlpProvider.SetHelpString(namRb, "Click chon neu gioi tinh la Nam.".ToString());

            hlpProvider.SetShowHelp(nuRB, true);
            hlpProvider.SetHelpString(nuRB, "Click chon neu gioi tinh la Nu.".ToString());

            hlpProvider.SetShowHelp(ngaySinhDTP, true);
            hlpProvider.SetHelpString(ngaySinhDTP, "Nhap Ngay Sinh cua nhan vien.");

            hlpProvider.SetShowHelp(diaChiTB, true);
            hlpProvider.SetHelpString(diaChiTB, "Nhap Dia Chi cua nhan vien.");

            hlpProvider.SetShowHelp(sdtTB, true);
            hlpProvider.SetHelpString(sdtTB, "Nhap So Dien Thoai cua nhan vien.");

            hlpProvider.SetShowHelp(luongTB, true);
            hlpProvider.SetHelpString(luongTB, "Nhap Luong cua nhan vien.");

            hlpProvider.SetShowHelp(comboBox1, true);
            hlpProvider.SetHelpString(comboBox1, "Click chon Phong Ban cua nhan vien.");

            hlpProvider.SetShowHelp(themButton, true);
            hlpProvider.SetHelpString(themButton, "1. Click Reset button." + Environment.NewLine + "2. Nhap thong tin cua Nhan Vien." + Environment.NewLine + "3. Click Them button de them moi.");

            hlpProvider.SetShowHelp(suaButton, true);
            hlpProvider.SetHelpString(suaButton, "1. Click chon Nhan Vien muon sua o danh sach ben duoi." + Environment.NewLine + "2. Sua thong tin cua Nhan Vien." + Environment.NewLine + "3. Click Sua button de sua thong tin.");

            hlpProvider.SetShowHelp(xoaButton, true);
            hlpProvider.SetHelpString(xoaButton, "1. Click chon Nhan Vien muon xoa o danh sach ben duoi." + Environment.NewLine + "2. Click Xoa button de xoa.");

            hlpProvider.SetShowHelp(resetButton, true);
            hlpProvider.SetHelpString(resetButton, "Click de reset.");

            hlpProvider.SetShowHelp(searchButton, true);
            hlpProvider.SetHelpString(searchButton, "1. Nhap thong tin tim kiem o ben canh" + Environment.NewLine + "2. Click Tim Kiem button de tim kiem." + Environment.NewLine + "3. Ket qua tim kiem hien thi o danh sach ben duoi.");

            hlpProvider.SetShowHelp(searchTB, true);
            hlpProvider.SetHelpString(searchTB, "Nhap thong tin tim kiem.");

            hlpProvider.SetShowHelp(NVdgv, true);
            hlpProvider.SetHelpString(NVdgv, "Click de chon Nhan Vien.");
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            isHelp = !isHelp;
            MaximizeBox = !isHelp;
            MinimizeBox = !isHelp;
        }
    }
}
