using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja01._11
{
    class Monster
    {
        private string imie;
        private int hp;

        public Monster(string imie, int hp)
        {
            this.Imie = imie;
            this.Hp = hp;
        }

        public string Imie { get => imie; set => imie = value; }
        public int Hp { get => hp; set => hp = value; }

        public Monster Clone()
        {
            return (Monster)MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Monster {imie} ma {hp}";
        }
    }
}
