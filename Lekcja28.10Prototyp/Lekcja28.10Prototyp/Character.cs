using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja28._10Prototyp
{
    abstract class Character
    {
        private int hp;

        public Character(int hp)
        {
            this.Hp = hp;
        }

        public int Hp { get => hp; set => hp = value; }

        public abstract void PrzyjmiCios(int silaCiosu);

        public abstract void ZadajCios(Character character);


        public override string ToString()
        {
            return $"Character ma {hp}";
        }
    }
}
