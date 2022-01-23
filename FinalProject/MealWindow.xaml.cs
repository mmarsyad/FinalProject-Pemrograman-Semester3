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
    /// Interaction logic for MealWindow.xaml
    /// </summary>
    public partial class MealWindow : Window
    {
        public MealWindow()
        {
            InitializeComponent();
        }

        private void btnMout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mai = new MainWindow();
            mai.Show();
            this.Close();
        }
    }
}
