using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

namespace Lekcja07._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Game> games = new List<Game>();
        private List<Game> games2 = new List<Game>();
        double sum = 0;

        public MainWindow()
        {
            InitializeComponent();
            ListBox1.ItemsSource = games;
            LoadGames();
            ListBox2.ItemsSource = games2;
        }

        public void LoadGames()
        {
            WebClient http = new WebClient ();
            var response = http.DownloadString("https://www.cheapshark.com/api/1.0/deals?storeID=1&upperPrice=1000");
            var newGames = JsonConvert.DeserializeObject<List<Game>>(response);
            games.AddRange(newGames);
            ListBox1.Items.Refresh();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (ListBox1.SelectedItem is Game game)
            {
                games2.Add(game);
                ListBox2.Items.Refresh();
                sum += game.salePrice;
                double ShortSum = Math.Round(sum, 2);
                Koszyk.Content = ShortSum.ToString();
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (ListBox2.SelectedItem is Game game)
            {
                games2.Remove(game);
                sum -= game.salePrice;
                double Shortsum = Math.Round(sum, 2);
                Koszyk.Content = Shortsum.ToString();
                ListBox2.Items.Refresh();
            }
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ListBox1.SelectedItem is Game game)
            {
                GameWindow gw = new GameWindow(game);
                gw.ShowDialog();
            }
        }

        private void NewGameBtn_Click(object sender, RoutedEventArgs e)
        {
            NewGameWindow gw = new NewGameWindow();
            if(gw.ShowDialog() == true)
            {
                games.Add(gw.game);
                ListBox1.Items.Refresh();
            }
        }
    }
}
