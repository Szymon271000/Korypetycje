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

namespace GUI_application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string pamiec = "0";
        private string operacja = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Click ;)");

            MessageBox.Show("Witaj " + imieTb.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(resultTb.Text != "0")
            {
                resultTb.Text += "0";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(resultTb.Text == "0")
            {
                resultTb.Text = "1";
            }
            else
            {
                resultTb.Text += "1";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (resultTb.Text == "0")
            {
                resultTb.Text = "2";
            }
            else
            {
                resultTb.Text += "2";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (resultTb.Text == "0")
            {
                resultTb.Text = "3";
            }
            else
            {
                resultTb.Text += "3";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            resultTb.Text = "0";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            operacja = "+";
            pamiec = resultTb.Text;
            resultTb.Text = "0"; //tymczasowo
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if(operacja == "+")
            {
                int a = int.Parse(pamiec);
                int b = int.Parse(resultTb.Text);
                int wynik = a + b;
                resultTb.Text = wynik.ToString();
                pamiec = "0";
                operacja = "";
            }
            if (operacja == "-")
            {
                int a = int.Parse(pamiec);
                int b = int.Parse(resultTb.Text);
                int wynik = a - b;
                resultTb.Text = wynik.ToString();
                pamiec = "0";
                operacja = "";
            }
            if (operacja == "*")
            {
                int a = int.Parse(pamiec);
                int b = int.Parse(resultTb.Text);
                int wynik = a * b;
                resultTb.Text = wynik.ToString();
                pamiec = "0";
                operacja = "";
            }
            if (operacja == "/")
            {
                int a = int.Parse(pamiec);
                int b = int.Parse(resultTb.Text);
                if (a == 0 & b == 0)
                {
                    MessageBox.Show($"Dzielenie {a} / {b} jest niemozliwe");
                }
                else if (b == 0)
                {
                    MessageBox.Show($"Dzielenie {a} / {b} jest niemozliwe");
                }
                else
                {
                    int wynik = a / b;
                    resultTb.Text = wynik.ToString();
                    pamiec = "0";
                    operacja = "";
                }
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (resultTb.Text == "0")
            {
                resultTb.Text = "4";
            }
            else
            {
                resultTb.Text += "4";
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (resultTb.Text == "0")
            {
                resultTb.Text = "5";
            }
            else
            {
                resultTb.Text += "5";
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (resultTb.Text == "0")
            {
                resultTb.Text = "6";
            }
            else
            {
                resultTb.Text += "6";
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (resultTb.Text == "0")
            {
                resultTb.Text = "7";
            }
            else
            {
                resultTb.Text += "7";
            }

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (resultTb.Text == "0")
            {
                resultTb.Text = "8";
            }
            else
            {
                resultTb.Text += "8";
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (resultTb.Text == "0")
            {
                resultTb.Text = "9";
            }
            else
            {
                resultTb.Text += "9";
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            operacja = "-";
            pamiec = resultTb.Text;
            resultTb.Text = "0";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            operacja = "*";
            pamiec = resultTb.Text;
            resultTb.Text = "0";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            operacja = "/";
            pamiec = resultTb.Text;
            resultTb.Text = "0";
        }
    }
}
