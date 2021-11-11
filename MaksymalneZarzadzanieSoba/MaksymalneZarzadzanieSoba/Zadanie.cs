using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymalneZarzadzanieSoba
{
    class Zadanie
    {
        private string tresc;
        private DateTime data;
        private string status;

        public Zadanie(string tresc, DateTime data, string status)
        {
            this.tresc = tresc;
            this.Data = data;
            this.Status = status;
        }

        public string Tresc { get => Tresc; set => Tresc = value; }

        public string Status { get => status; set => status = value; }
        public DateTime Data { get => data; set => data = value; }

        public void ZmienStatus(string Inputstatus)
        {
             Status = Inputstatus;
        }
        public override string ToString()
        {
            return $"{tresc} {Data} {Status}";
        }

        public string ToCSV()
        {
            return $"{tresc};{Data.ToShortDateString()};{Status}";
        }
    }
}
