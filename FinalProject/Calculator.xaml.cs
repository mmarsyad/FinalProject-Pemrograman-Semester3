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
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnCalout_Click(object sender, RoutedEventArgs e)
        {
            BMICalculator jad = new BMICalculator();
            jad.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            double bil1, bil2, bil3, bil4;
            bil1 = double.Parse(txtHeight.Text);
            bil2 = double.Parse(txtWeight.Text);
            bil3 = (bil1 / 100) * (bil1 / 100);
            bil4 = bil2 / bil3;

            if (bil4 >= 18 && bil4 <= 23)
            {
                MessageBox.Show("BMI : " + bil4 + " Anda dalam keadaan normal");
            }
            if (bil4 <= 18 )
            {
                MessageBox.Show("BMI : " + bil4 + " Anda dalam keadaan kurang ideal");
            }
            if (bil4 >= 23)
            {
                MessageBox.Show("BMI : " + bil4 + " Anda kelebihan berat badan");
            }
        }
    }
}
