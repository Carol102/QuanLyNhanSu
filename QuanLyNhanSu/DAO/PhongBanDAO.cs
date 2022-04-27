using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyNhanSu.DTO;

namespace QuanLyNhanSu.DAO
{
    class PhongBanDAO
    {
        private static PhongBanDAO instance;

        internal static PhongBanDAO Instance
        {
            get { if (instance == null) instance = new PhongBanDAO(); return instance; }
            private set { instance = value; }
        }
        public List<PhongBanDTO> GetAll()
        {
            List<PhongBanDTO> list = new List<PhongBanDTO>();
            DataTable data = DataAccess.Instance.ExecuteQuery("[dbo].[getPhongBan]");
            foreach (DataRow item in data.Rows)
            {
                PhongBanDTO entry = new PhongBanDTO(item);
                list.Add(entry);
            }
            return list;
        }

        public bool Insert(string tenPhongBan, string sdt, string mota)
        {
            int result = DataAccess.Instance.ExecuteNonQuery("[dbo].[insertPhongBan] @tenPB , @sdtPB , @motaPB", new object[] { tenPhongBan, sdt, mota });
            return result > 0;
        }

    

    }
}
