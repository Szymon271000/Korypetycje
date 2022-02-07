using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Lekcja27._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataContext dataContext = new DataContext();
        public MainWindow()
        {
            InitializeComponent();
            Rates.OnRateAdded += Rates_OnRateAdded;
            Rates.OnRateAdded += Rates_OnRateAdded2;
        }

        private void Rates_OnRateAdded2(object sender, int e)
        {
            Thread t = new Thread(() =>
            {
                dataContext.Add(new Note { Wartosc = e });
                dataContext.SaveChanges();
                Thread.Sleep(5000);
                Console.WriteLine("Saved to db");
            });
            t.Start();
        }

        private void Rates_OnRateAdded(object sender, int e)
        {
            MessageBox.Show("Dziękujemy za ocenę: " + e);
        }
    }
}
