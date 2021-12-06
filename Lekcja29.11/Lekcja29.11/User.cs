using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja29._11
{
    public class User
    {
        public int Id { get; set; }
        public string? Imie { get; set; } //? od teraz te pola moga tez przyjmowac null
        [Required, EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
    }
}
