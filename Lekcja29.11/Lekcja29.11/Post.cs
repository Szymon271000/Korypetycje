using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja29._11
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string? Text { get; set; }
        [Required]
        public User? Author { get; set; }

        public DateTime PostingDate { get; set; } = DateTime.Now;

        public override string? ToString()
        {
            return $"{Text} uzytkowanika {Author.Imie}";
        }
    }
}
