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
    /// Interaction logic for BMICalculator.xaml
    /// </summary>
    public partial class BMICalculator : Window
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void btnBmiout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void btnLaki_Click(object sender, RoutedEventArgs e)
        {
            Calculator cal = new Calculator();
            cal.Show();
            this.Close();
        }

        private void btnPer_Click(object sender, RoutedEventArgs e)
        {
            Calculator cal1 = new Calculator();
            cal1.Show();
            this.Close();
        }
    }
}
