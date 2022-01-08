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

namespace PO_Lab8
{
    /// <summary>
    /// Interaction logic for Ocane.xaml
    /// </summary>
    public partial class Ocane : Window
    {
        Ocena o1 = new Ocena();
        Ocena o2 = new Ocena();
        Ocena o3 = new Ocena();
        public List<Ocena> notes = new List<Ocena>();

        public Ocane()
        {
            InitializeComponent();
        }

        private void DodajOceny_Click(object sender, RoutedEventArgs e)
        {
            o1.Note = int.Parse(Ocena1.Text);
            o2.Note = int.Parse(Ocena2.Text);
            o3.Note = int.Parse(Ocena3.Text);
            notes.Add(o1);
            notes.Add(o2);
            notes.Add(o3);
            this.DialogResult = true;
        }
    }
}
