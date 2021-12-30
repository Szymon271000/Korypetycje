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

namespace Lekcja30._12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Symbol = "X";
        private bool stop = false;

        private Dictionary<string, Color> colors = new Dictionary<string, Color>
        {
            { "X", Colors.Cyan },
            { "O", Colors.Red }
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToggleSymbol()
        {
            if (Symbol == "X")
            {
                Symbol = "O";
            }
            else
            {
                Symbol = "X";
            }
        }

        private bool CheckWin()
        {
            string[,] tab = new string[,]
            {
               { Square1.Content.ToString(), Square2.Content.ToString(),Square3.Content.ToString() },
               { Square4.Content.ToString(), Square5.Content.ToString(),Square6.Content.ToString() },
               { Square7.Content.ToString(), Square8.Content.ToString(),Square9.Content.ToString() }
            };

            string winner = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                if (tab[i, 0] == tab[i, 1] && tab[i, 1] == tab[i, 2] && tab[i, 0] != string.Empty)
                {
                    winner = tab[i, 0];
                    break;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (tab[0, i] == tab[1, i] && tab[1, i] == tab[2, i] && tab[0, i] != string.Empty)
                {
                    winner = tab[0,1];
                    break;
                }
            }
            if (tab[0,0] == tab [1,1] && tab[1,1] == tab[2,2] && tab[0,0] == tab[2,2] && tab[0,0] != string.Empty)
            {
                winner = tab[1, 1];
            }
            if (tab[0,2] == tab [1,1] && tab[1,1] == tab[2,0] && tab[0,2] == tab[2,0] && tab[0,2] != string.Empty)
            {
                winner = tab[1, 1];
            }

            if(winner != string.Empty)
            {
                MessageBox.Show($"{winner} wygral");
                return true;
            }

            return false;
        }

        private void Square1_Click(object sender, RoutedEventArgs e)
        {
            if(stop)
            {
                return;
            }

            Button b = sender as Button;
            if (string.IsNullOrEmpty(b.Content.ToString()))
            {
                b.Content = Symbol;
                b.Background = new SolidColorBrush(colors[Symbol]);
                ToggleSymbol();
                
                stop = CheckWin();
            }
        }
    }
}
