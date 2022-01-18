using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PO_Lab8
{
    /// <summary>
    /// Interaction logic for Ocane.xaml
    /// </summary>
    public partial class Ocane : Window
    {
        public Ocena Ocena { get; set; } = new Ocena();

        public Ocane()
        {
            InitializeComponent();
        }

        private void DodajOceny_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(Ocena1.Text,@"^[2-5]{1}$"))
            {
                Ocena.Note = int.Parse(Ocena1.Text);
                this.DialogResult = true;
            }
            else
            {
                MessageBox.Show("Niepoprawna ocena");
            }
        }
    }
}
