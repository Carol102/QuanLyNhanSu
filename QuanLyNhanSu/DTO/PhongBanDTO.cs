using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhanSu.DTO
{
    class PhongBanDTO
    {
        private int idPb;
        private string tenPb;
        private string sdtPb;
        private string motaPb;

        public int IDPB
        {
            get { return idPb; }
            set { idPb = value; }
        }
        public string TenPb
        {
            get { return tenPb; }
            set { tenPb = value; }
        }
        public string SdtPb
        {
            get { return sdtPb; }
            set { sdtPb = value; }
        }
        public string MotaPb
        {
            get { return motaPb; }
            set { motaPb = value; }
        }

        public PhongBanDTO()
        {
            // Default constructor
        }

        public PhongBanDTO(int id, string ten, string sdt, string mota)
        {
            this.idPb = id;
            this.tenPb = ten;
            this.sdtPb = sdt;
            this.motaPb = mota;
        }

        public PhongBanDTO(DataRow row)
        {
            Int32.TryParse(row["id_PhongBan"].ToString(), out idPb);
            this.tenPb = row["ten_PhongBan"].ToString();
            this.sdtPb = row["sdt_PhongBan"].ToString();
            this.motaPb = row["mota_PhongBan"].ToString();
        }
    }
}
