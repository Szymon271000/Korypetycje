using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja07._01
{
    public class Game
    {
        public string title { get; set; }
        public float salePrice { get; set; }
        public float normalPrice { get; set; }
        public string steamRatingText { get; set; }

        public override string ToString()
        {
            return $"{title} {salePrice} {normalPrice} {steamRatingText}";
        }
    }
}
