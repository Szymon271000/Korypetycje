using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja28._10Prototyp
{
    class Knight : Character
    {
        public Knight() : base(100)
        {
            
        }
        public override void PrzyjmiCios(int silaCiosu)
        {
            Hp = Hp - silaCiosu;
        }

        public override void ZadajCios(Character character)
        {
            character.PrzyjmiCios(15);
        }
    }
}
