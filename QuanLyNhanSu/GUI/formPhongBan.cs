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
            Help();
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
            int idPB;
            Int32.TryParse(idLabel.Text.Trim(), out idPB);
            string tenPB = tenPBTbox.Text.Trim();
            string sdt = sdtPbTB.Text.Trim();
            string mota = moTaTB.Text.Trim();

            try
            {
                if (tenPB == "" || idPB == -1 || sdt == "" || mota == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
                PhongBanDAO.Instance.Update(idPB, tenPB, sdt, mota);
                MessageBox.Show("Sửa thành công!");
                PBdgv.DataSource = pbDAO.GetAll();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra!" + err.ToString());
                PBdgv.DataSource = pbDAO.GetAll();
            }
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            int idPB;
            Int32.TryParse(idLabel.Text.Trim(), out idPB);
            try
            {
                PhongBanDAO.Instance.Delete(idPB);
                MessageBox.Show("Xóa thành công!");
                PBdgv.DataSource = pbDAO.GetAll();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra!" + err.ToString());
                PBdgv.DataSource = pbDAO.GetAll();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string str = searchTB.Text.Trim();
            if (str == "")
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                return;
            }
            PBdgv.DataSource = PhongBanDAO.Instance.Search(str);
        }

        private void searchTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string str = searchTB.Text.Trim();
                if (str == "")
                {
                    MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                    return;
                }
                PBdgv.DataSource = PhongBanDAO.Instance.Search(str);
            }
        }
		
        private HelpProvider hlpProvider;
        bool isHelp = false;
		
        private void Help()
        {
            hlpProvider = new HelpProvider();

            hlpProvider.SetShowHelp(backButton, true);
            hlpProvider.SetHelpString(backButton, "Tro ve man hinh truoc.");

            hlpProvider.SetShowHelp(tenPBTbox, true);
            hlpProvider.SetHelpString(tenPBTbox, "Nhap Ten Phong Ban.");

            hlpProvider.SetShowHelp(sdtPbTB, true);
            hlpProvider.SetHelpString(sdtPbTB, "Nhap SDT cua Phong Ban.");

            hlpProvider.SetShowHelp(moTaTB, true);
            hlpProvider.SetHelpString(moTaTB, "Nhap Mo Ta cua Phong Ban.");

            hlpProvider.SetShowHelp(themButton, true);
            hlpProvider.SetHelpString(themButton, "1. Click Reset button." + Environment.NewLine + "2. Nhap thong tin cua Phong Ban." + Environment.NewLine + "3. Click Them button de them moi.");

            hlpProvider.SetShowHelp(suaButton, true);
            hlpProvider.SetHelpString(suaButton, "1. Click chon Phong Ban muon sua o danh sach ben duoi." + Environment.NewLine + "2. Sua thong tin cua Phong Ban." + Environment.NewLine + "3. Click Sua button de sua thong tin.");

            hlpProvider.SetShowHelp(xoaButton, true);
            hlpProvider.SetHelpString(xoaButton, "1. Click chon Phong Ban muon xoa o danh sach ben duoi." + Environment.NewLine + "2. Click Xoa button de xoa.");

            hlpProvider.SetShowHelp(resetButton, true);
            hlpProvider.SetHelpString(resetButton, "Click de reset.");

            hlpProvider.SetShowHelp(searchButton, true);
            hlpProvider.SetHelpString(searchButton, "1. Nhap thong tin tim kiem o ben canh" + Environment.NewLine + "2. Click Tim Kiem button de tim kiem." + Environment.NewLine + "3. Ket qua tim kiem hien thi o danh sach ben duoi.");

            hlpProvider.SetShowHelp(searchTB, true);
            hlpProvider.SetHelpString(searchTB, "Nhap thong tin tim kiem.");

            hlpProvider.SetShowHelp(PBdgv, true);
            hlpProvider.SetHelpString(PBdgv, "Click de chon Phong Ban.");

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            isHelp = !isHelp;
            MaximizeBox = !isHelp;
            MinimizeBox = !isHelp;
        }
       
    }
}


