using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja29._11
{
    public class Like
    { 
        public int Id { get; set; }
        public User ?User { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
        public Post ?Post { get; set; }

    }
}
