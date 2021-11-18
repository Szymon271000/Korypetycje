using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18._11
{
    class CarNameComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if(x.Marka == y.Marka)
            {
                return x.Model.CompareTo(y.Model);
            }
            return x.Marka.CompareTo(y.Marka);
        }
    }
}
