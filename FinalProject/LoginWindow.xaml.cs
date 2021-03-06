using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        Controller.User user;

        public LoginWindow()
        {
            InitializeComponent();

            user = new Controller.User(this);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            user.Login();
        }

        private void lblSign_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RegisterWindow register = new RegisterWindow();
            register.Show();
            this.Close();
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Show();
            this.Close();
        }
    }
}
