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
using System.Windows.Shapes;

namespace Lekcja07._01
{
    /// <summary>
    /// Interaction logic for NewGameWindow.xaml
    /// </summary>
    public partial class NewGameWindow : Window
    {
        public Game game = new Game();
        public NewGameWindow()
        {
            InitializeComponent();
        }

        private void DodajButton_Click(object sender, RoutedEventArgs e)
        {
            if (Title.Text != string.Empty && SalePrice.Text != string.Empty && NormalPrice.Text != string.Empty && SteamRatingText.Text != string.Empty)
            {
                game.title = Title.Text;
                game.salePrice = float.Parse(SalePrice.Text);
                game.normalPrice = float.Parse(NormalPrice.Text);
                game.steamRatingText = SteamRatingText.Text;
                this.DialogResult = true;
            }
        }
    }
}
