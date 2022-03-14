using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhanSu.DTO
{
    class NhanVienDTO
    {
        private int idNv;
        private string tenNv;
        private string gioitinhNv;
        private DateTime ngaysinhNv;
        private string diachiNv;
        private string sdtNv;
        private int luongNv;
        private int pbNv;

        public int IDNv
        {
            get { return idNv; }
            set { idNv = value; }
        }
        public string TenNv
        {
            get { return tenNv; }
            set { tenNv = value; }
        }
        public string GioitinhNv
        {
            get { return gioitinhNv; }
            set { gioitinhNv = value; }

        }
        public DateTime NgaysinhNv
        {
            get { return ngaysinhNv; }
            set { ngaysinhNv = value; }
        }
        public string DiachiNv
        {
            get { return diachiNv; }
            set { diachiNv = value; }
        }
        public string SdtNv
        {
            get { return sdtNv; }
            set { sdtNv = value; }
        }
        public int LuongNV
        {
            get { return luongNv; }
            set { luongNv = value; }
        }
        
        public int PbNv
        {
            get { return pbNv; }
            set { pbNv = value; }
        }

        public NhanVienDTO()
        {
            // Default constructor
        }

        public NhanVienDTO(int id, string ten, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt, int luong, int phongBan)
        {
            this.idNv = id;
            this.tenNv = ten;
            this.gioitinhNv = gioiTinh;
            this.ngaysinhNv = ngaySinh;
            this.diachiNv = diaChi;
            this.sdtNv = sdt;
            this.luongNv = luong;
            this.pbNv = phongBan;
        }

        public NhanVienDTO(DataRow row)
        {
            Int32.TryParse(row["id_NhanVien"].ToString(), out this.idNv);
            this.tenNv = row["ten_NhanVien"].ToString();
            this.gioitinhNv = row["gioitinh_NhanVien"].ToString();
            this.ngaysinhNv = (DateTime)row["ngaysinh_NhanVien"];
            this.diachiNv = row["diachi_NhanVien"].ToString();
            this.sdtNv = row["sdt_NhanVien"].ToString();
            Int32.TryParse(row["luong_NhanVien"].ToString(), out this.luongNv);
            Int32.TryParse(row["id_PhongBan"].ToString(), out this.pbNv);
        }
    }
}
