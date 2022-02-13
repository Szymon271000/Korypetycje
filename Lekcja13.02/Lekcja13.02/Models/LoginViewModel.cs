using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lekcja13._02.Models
{
    public class LoginViewModel
    {
        [Required]
        [MaxLength(30)]
        public string  Login { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(15)]
        public string Password { get; set; }

    }
}
