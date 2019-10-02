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

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a;
        double b;
        double c;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cong_Click(object sender, RoutedEventArgs e)
        {
            c = a + b;
            LamTron(ref c);
            Number3.Text = c.ToString();
        }

        private void Number1_TextChanged(object sender, TextChangedEventArgs e)
        {
            a = Double.Parse(Number1.Text);
        }

        private void Number2_TextChanged(object sender, TextChangedEventArgs e)
        {
            b = Double.Parse(Number2.Text);
        }

        private void tru_Click(object sender, RoutedEventArgs e)
        {
            c = a - b;
            LamTron(ref c);
            Number3.Text = c.ToString();
        }

        private void nhan_Click(object sender, RoutedEventArgs e)
        {
            c = a * b;
            LamTron(ref c);
            Number3.Text = c.ToString();
        }

        private void ___Click(object sender, RoutedEventArgs e)
        {
            if (b == 0)
            {
                MessageBox.Show("Hãy nhập lại");
            }
            else
            {
                c = a / b;
                LamTron(ref c);
                Number3.Text = c.ToString();
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LamTron(ref Double c)
        {
            c = Math.Round(c, 1);
            if (c + 0.05 >= Math.Round(c, 2))
                c = Math.Round(c, 1) + 0.1;
              
        }
    }
}