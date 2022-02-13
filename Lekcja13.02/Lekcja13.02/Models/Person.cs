using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lekcja13._02.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Musisz wypełnić to pole!")]
        [MaxLength(30)]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Range(1, 115)]
        public int Age { get; set; }
    }
}
