using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace FinalProject.Controller
{
    class User
    {
        Model.UserClass user;
        LoginWindow login;

        public User(LoginWindow login)
        {
            user = new Model.UserClass();
            this.login = login;
        }

        public void Login()
        {
            user.username = login.txtUsername.Text;
            user.password = login.txtPassword.Text;
            bool result = user.CekLogin();
            if(result)
            {
                MainWindow main = new MainWindow();
                main.Show();
                login.Close();
            }
            else
            {
                MessageBox.Show("Maaf username/password anda salah!");
                login.txtUsername.Text = "";
                login.txtPassword.Text = "";
                login.txtUsername.Focus();
            }

        }
        RegisterWindow register;

        public User(RegisterWindow register)
        {
            user = new Model.UserClass();
            this.register = register;
        }

        public void Register()
        {
            user.id = register.txtSid.Text;
            user.nama = register.txtSname.Text;
            user.username = register.txtSuser.Text;
            user.password = register.txtSpass.Text;

            bool result = user.InsertUser();
            if(result)
            {
                MessageBox.Show("Pembuatan akun berhasil, " +
                                "silahkan login menggunakan username dan password anda!");
                LoginWindow login = new LoginWindow();
                login.Show();
                register.Close();
            }
            else
            {
                MessageBox.Show("Maaf registrasi akun gagal, " +
                                "periksa dan lengkapi data anda!");
            }
        }

    }
}
