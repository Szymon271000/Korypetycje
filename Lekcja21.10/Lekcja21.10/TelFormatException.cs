using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja21._10
{
    class TelFormatException : Exception
    {
        public TelFormatException(string tel) : base("Niepoprawny format nr telefonu " + tel)
        {

        }
    }
}
