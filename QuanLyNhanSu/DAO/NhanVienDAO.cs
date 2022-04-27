using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using QuanLyNhanSu.DTO;

namespace QuanLyNhanSu.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        internal static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        public List<NhanVienDTO> GetAll()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            DataTable data = DataAccess.Instance.ExecuteQuery("[dbo].[getNhanVien]");
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO entry = new NhanVienDTO(item);
                list.Add(entry);
            }
            return list;
        }

        public bool Insert(string tenNhanVien, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt, int luong, int idLopHoc)
        {
            int result = DataAccess.Instance.ExecuteNonQuery("[dbo].[insertNhanVien] @tenNV , @gioitinhNV , @ngaySinhNV , @diachiNV , @sdtNV , @luong_NV , @idPB", new object[] { tenNhanVien, gioiTinh, ngaySinh, diaChi, sdt, luong, idLopHoc });
            return result > 0;
        }

        public String selectPhongBan(String maPb)
        {
            String tenPB;
            String sql = "select ten_PhongBan from PhongBan where id_PhongBan='" + maPb + "'";
            tenPB = DataAccess.Instance.ExecuteScalar(sql).ToString();
            return tenPB;
        }

        public List<PhongBanDTO> GetListPhongBan()
        {
            List<PhongBanDTO> list = new List<PhongBanDTO>();
            DataTable data = DataAccess.Instance.ExecuteQuery("getPhongBan");
            foreach (DataRow item in data.Rows)
            {
                PhongBanDTO entry = new PhongBanDTO(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
