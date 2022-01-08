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

namespace PO_Lab8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            dg.ItemsSource = students;
            CreateLayout();
            Load();
            
        }

        public void CreateLayout()
        {
            dg.Columns.Add(new DataGridTextColumn() { Header = "Imie", Binding = new Binding("FirstName") });
            dg.Columns.Add(new DataGridTextColumn() { Header = "Nazwisko", Binding = new Binding("SurName") });
            dg.Columns.Add(new DataGridTextColumn() { Header = "NrIndeksu", Binding = new Binding("StudentNo") });
            dg.Columns.Add(new DataGridTextColumn() { Header = "Wydzial", Binding = new Binding("Faculty") });
            dg.Columns.Add(new DataGridTextColumn() { Header = "Oceny", Binding = new Binding("Ocena") });
            dg.AutoGenerateColumns = false;
        }

        public void Load()
        {
            /*students = new List<Student>()
            {
                new Student("Kowalski", "Jan", "1033", "WIMIi"),
                new Student("Nowak", "Michał", "1033", "WIMIi"), nie dziala spytac dlaczego
                new Student("Makieta", "Jacek", "1033", "WIMIi")
            };*/  
            Student s1 = new Student() { SurName = "Kowalski", FirstName = "Jan", StudentNo = 1332, Faculty ="WIMIi" };
            Student s2 = new Student(){ SurName ="Nowak", FirstName = "Michał", StudentNo = 1033, Faculty = "WIMIi" };
            Student s3 = new Student() { SurName = "Makieta", FirstName = "Jacek", StudentNo = 1256, Faculty = "WIMIi"};
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            dg.Items.Refresh();

        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new StudentWindow();
            if (dialog.ShowDialog() == true)
            {
                students.Add(dialog.student);
                dg.Items.Refresh();
            }
        }

        private void RemoveStudent_Click(object sender, RoutedEventArgs e)
        {
            if (dg.SelectedItem is Student student)
            {
                students.Remove(student);
                dg.Items.Refresh();
            }
        }

        private void AddNotes_Click(object sender, RoutedEventArgs e)
        {
            var ocena = new Ocane();
            if (dg.SelectedItem is Student student && ocena.ShowDialog() == true)
            {
                student.Oceny = ocena.notes;
                dg.Items.Refresh();
            }
        }
    }
}
