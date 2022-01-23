using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           /*Model.ModelTemplate cek = new Model.ModelTemplate();
            cek.cekKoneksi();*/
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.Show();
            this.Close();
        }

        private void btnMeal_Click(object sender, RoutedEventArgs e)
        {
            MealWindow meal = new MealWindow();
            meal.Show();
            this.Close();
        }

        private void btnCal_Click(object sender, RoutedEventArgs e)
        {
            BMICalculator bmi = new BMICalculator();
            bmi.Show();
            this.Close();
        }

        private void btnSignout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Close();
        }
    }
}
