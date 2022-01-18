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
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public Student student;
        public StudentWindow(Student student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                ImieBox.Text = student.FirstName;
                NazwiskoBox.Text = student.SurName;
                NrIndeksuBox.Text = student.StudentNo.ToString();
                WydzialBox.Text = student.Faculty;
            }
            this.student = student ?? new Student();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
          //if (!Regex.IsMatch(ImieBox.Text, @"^\p{Lu}\p{Ll}{1,12}$") ||
          //      !Regex.IsMatch(NazwiskoBox.Text, @"^\p{Lu}\p{Ll}{1,12}$") || 
          //      !Regex.IsMatch(WydzialBox.Text, @"^\p{Lu}\p{Ll}{1,12}$") ||
          //      !Regex.IsMatch(NrIndeksuBox.Text, @"[0-9] {4,10}"))
          //  {
          //      MessageBox.Show("Nie poprawne dane");
          //      return;
          //  }
            student.FirstName = ImieBox.Text;
            student.SurName = NazwiskoBox.Text;
            student.StudentNo = int.Parse(NrIndeksuBox.Text);
            student.Faculty = WydzialBox.Text;
            this.DialogResult = true;
        }
    }
}
