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
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public GameWindow(Game game)
        {
            InitializeComponent();
            Title.Content = game.title;
            SalePrice.Content = game.salePrice;
            NormalPrice.Content = game.normalPrice;
            SteamRatingText.Content = game.steamRatingText;
        }

    }
}
