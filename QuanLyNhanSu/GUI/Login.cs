﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyNhanSu.DAO;
using QuanLyNhanSu.GUI;

namespace QuanLyNhanSu
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        LoginDAO login = new LoginDAO();

        private void loginButton_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Tên đăng nhập không được để trống!");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                txtPassword.Focus();
                return;
            }

            String condition;
            condition = " username ='" + username + "' AND password ='" + password + "'";
            DataTable dt = new DataTable();
            try
            {
                dt = login.getUser(condition);
                if (dt.Rows.Count > 0)
                {
                    formMain frm = new formMain();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập sai cú pháp");
            }
            catch (SqlException)
            {
                MessageBox.Show("lỗi kết nối csdl !");
            }
        }
    }
}
