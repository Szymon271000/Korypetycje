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
        private List<Ocena> oceny = new List<Ocena>();

        public string SurName { get => surName; set => surName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public int StudentNo { get => studentNo; set => studentNo = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public List<Ocena> ListaOcen { get => oceny; set => oceny = value; }
        //public string Oceny => oceny.Count > 0 ? oceny.Select(o => o.Note.ToString()).Aggregate((s1, s2) => s1 + " " + s2) : "";

        public string Oceny
        {
            get
            {
                //string napis = string.Empty;
                //foreach (var item in oceny)
                //{
                //    napis += $"{item.Note.ToString()} ";
                //}
                //return napis;

                StringBuilder builder = new StringBuilder();
                foreach (var item in oceny)
                {
                    builder.Append($"{item.Note.ToString()} ");
                }
                return builder.ToString();
            }
        }
    }
}
