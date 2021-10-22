using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja21._10
{
    class TelefonExtension
    {
        public static bool PoprawnyNrTel(string tel)
        {
            if (tel.Length != 9)
            {
                return false;
            }

            try
            {
                int.Parse(tel);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
