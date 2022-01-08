using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Lab8
{
    public class Student
    {
        private string surName;
        private string firstName;
        private int studentNo;
        private string faculty;
        private List<Ocena> oceny;

        public string SurName { get => surName; set => surName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public int StudentNo { get => studentNo; set => studentNo = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public List<Ocena> Oceny { get => oceny; set => oceny = value; }
    }
}
