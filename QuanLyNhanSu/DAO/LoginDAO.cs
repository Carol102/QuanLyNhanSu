using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using QuanLyNhanSu.DTO;

namespace QuanLyNhanSu.DAO
{
    class LoginDAO
    {
        public DataTable getUser(String condition)
        {
            DataTable dt = null;
            String sql = "Select * from Login where " + condition;
            dt = DataAccess.Instance.getTable(sql);
            return dt;
        }
    }
}
