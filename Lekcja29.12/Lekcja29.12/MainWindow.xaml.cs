using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;


namespace Lekcja29._12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserContext context = new UserContext();
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = new ObservableCollection<User>(context.Users);
        }

        private void ZajerestrujBT_Click(object sender, RoutedEventArgs e)
        {
            bool blad = false;
            if (ImieTB.Text == string.Empty)
            {
                MessageBox.Show("Nie podano imienia");
                blad = true;
            }
            if (NazwiskoTB.Text == string.Empty)
            {
                MessageBox.Show("Nie podano nazwiska");
                blad = true;
            }
            if (Haslo1TB.Password == string.Empty)
            {
                MessageBox.Show("Nie podano hasla");
                blad = true;
            }
            if (Haslo1TB.Password != Haslo2TB.Password)
            {
                MessageBox.Show("Podane hasla sa nierowne");
                blad = true;
            }
            
            if (blad == false)
            {
                User u = new User()
                {
                    Imie = ImieTB.Text,
                    Nazwisko = NazwiskoTB.Text,
                    Password = Haslo1TB.Password
                };
                context.Add(u);
                context.SaveChanges();
                MessageBox.Show("Dodano uzytkownika!");
                ImieTB.Text = string.Empty;
                NazwiskoTB.Text = string.Empty;
                Haslo1TB.Password = string.Empty;
                Haslo2TB.Password = string.Empty;

                dataGrid.Items.Refresh();
            }

        }

        private void ZalogujBT_Click(object sender, RoutedEventArgs e)
        {
            bool blad = false;
            if (Nazwisko2TB.Text == string.Empty)
            {
                MessageBox.Show("Nie podano nazwiska");
                blad = true;
            }
            if (Haslo3TB.Password == string.Empty)
            {
                MessageBox.Show("Nie podano hasla");
                blad = true;
            }
            if (blad == false)
            {
                var user = context.Users.Any(x => x.Nazwisko == Nazwisko2TB.Text && x.Password == Haslo3TB.Password);
                if (user)
                {
                    MessageBox.Show("Zalogowany");
                }
                else
                {
                    MessageBox.Show("Nie udalo sie zalogowac");
                }

            }
        }
    }
}
