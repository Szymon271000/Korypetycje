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

namespace Lekcja03._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Car> cars = new List<Car>();
        public MainWindow()
        {
            InitializeComponent();
            listBox.ItemsSource = cars;
        }

        private void NazwaBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NazwaBox.Text != string.Empty && RejestracjaBox.Text != string.Empty && NumerMiejscaBox.Text != string.Empty)
            {
                Car c = new Car(NazwaBox.Text, RejestracjaBox.Text, int.Parse(NumerMiejscaBox.Text)); // content nie jest stringiem, text jest
                cars.Add(c);
                listBox.Items.Refresh();
            }
        }

        private void UsunButton_Click(object sender, RoutedEventArgs e)
        {
            if(listBox.SelectedItem is Car car)
            {
                cars.Remove(car);
                listBox.Items.Refresh();
            }
        }

        private void PobierzButton_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem is Car car)
            {
                NazwaBox.Text = car.Nazwa;
                RejestracjaBox.Text = car.Rejestracja;
                NumerMiejscaBox.Text = car.NumerMiejsca.ToString();
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem is Car car)
            {
                NazwaBox.Text = car.Nazwa;
                RejestracjaBox.Text = car.Rejestracja;
                NumerMiejscaBox.Text = car.NumerMiejsca.ToString();
            }

        }
    }
}
