using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja03._02
{
    static class ListUtils
    {
        public static string ElementsToString<T>(this List<T> lista)
        {
            return lista.Select(x => x.ToString()).Aggregate((x, y) => x + "\n" + y);
        }
    }
}
