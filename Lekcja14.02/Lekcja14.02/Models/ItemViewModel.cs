using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lekcja14._02.Models
{
    public class ItemViewModel
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Category { get; set; }
        [Range(0, 50000)]
        public double Price { get; set; }
    }
}
