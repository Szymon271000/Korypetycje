using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckList.Models
{
    public class Goal
    {
        public int Id { get; set; }

        public string Category { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        public bool Done { get; set; } = false;

    }
}
