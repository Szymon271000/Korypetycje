using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lekcja04._03_Sklep.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public bool Done { get; set; }
    }
}
