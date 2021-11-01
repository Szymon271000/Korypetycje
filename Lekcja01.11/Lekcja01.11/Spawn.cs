using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja01._11
{
    class Spawn
    {
        List<Monster> monsters = new List<Monster>();

        public void Add (Monster m)
        {
            monsters.Add(m);
        }

        public Monster create(string imie)
        {
            for (int i = 0; i < monsters.Count; i++)
            {
                if (imie == monsters[i].Imie)
                {
                    return monsters[i].Clone();
                }
            }

            throw new KeyNotFoundException();
            
        }
    }
}
