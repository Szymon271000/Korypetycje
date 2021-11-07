using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class PlacParkingowy
    {
        private int id;
        private string letter;
        static int counter;
        private bool status = true;

        public int Id { get => id; set => id = value; }
        public string Letter { get => letter; set => letter = value; }
        public bool Status { get => status; set => status = value; }

        public PlacParkingowy(string letter)
        {
            this.Id = id;
            counter++;
            id = counter;
            this.Letter = letter;
            this.Status = Status;
        }

        public override string ToString()
        {
            return $"Plac id: {id} {letter} {status}";
        }
    }
}
