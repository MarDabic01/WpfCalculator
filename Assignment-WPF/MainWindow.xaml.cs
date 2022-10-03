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

namespace Assignment_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float a, b, c;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            operationLabel.Content = "+";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            operationLabel.Content = "-";
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            operationLabel.Content = "*";
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            operationLabel.Content = "/";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (provjera() == true)
            {
                a = float.Parse(num1.Text);
                b = float.Parse(num2.Text);
                if (opr1.IsChecked == true)
                    c = a + b;
                else if (opr2.IsChecked == true)
                    c = a - b;
                else if (opr3.IsChecked == true)
                    c = a * b;
                else
                    c = a / b;
                result.Text = c.ToString();
            }
        }
        
        private bool provjera()
        {
            float x;
            if (num1.Text == "" || num2.Text == "")
            {
                result.Text = "Unos nije ispravan";
                return false;
            }
            else if (num2.Text == "0" && opr4.IsChecked == true)
            {
                result.Text = "Dijeljenje sa 0 nije definisano";
                return false;
            }
            else if(float.TryParse(num1.Text,out x) == false || float.TryParse(num2.Text,out x) == false)
            {
                result.Text = "Unos nije ispravan";
                return false;
            }
            return true;
        }
    }
}
