using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhanSu.DTO
{
    class LoginDTO
    {
        private string username;
        private string password;
        private int id_Nv;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int Id_Nv
        {
            get { return id_Nv; }
            set { id_Nv = value; }
        }

        public LoginDTO()
        {
            // Default constructor
        }

        public LoginDTO(string us, string pass, int idNv)
        {
            this.username = us;
            this.password = pass;
            this.id_Nv = idNv;
        }

        public LoginDTO(DataRow row)
        {
            Int32.TryParse(row["id_NhanVien"].ToString(), out this.id_Nv);
            this.username = row["username"].ToString();
            this.password = row["password"].ToString();
        }
    }
}
