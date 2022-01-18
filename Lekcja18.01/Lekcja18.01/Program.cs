using System;
using System.Text.RegularExpressions;

namespace Lekcja18._01
{
    class Program
    {
        static bool PoprawnyEmail(string email)
        {
            //literki cyfry minimun jeden znak
            //@
            //literki lub cyfry jeden znak
            //.
            //domena same znaki minimum 2
           
            
            bool poprawny = true;
            if (email.Contains('@') && email.Contains('.') )
            {
                string[] czesc = email.Split('@');
                foreach (var litera in czesc[0])
                {
                    if (!Char.IsLetter(litera) && !Char.IsDigit(litera))
                    {
                        poprawny = false;
                        break;
                    }
                }
                string[] cz2 = czesc[1].Split(".");
                foreach (var litera in cz2[0])
                {
                    if (!Char.IsLetter(litera) && !Char.IsDigit(litera))
                    {
                        poprawny = false;
                        break;
                    }
                }
                foreach (var litera in cz2[1])
                {
                    if (!Char.IsLetter(litera))
                    {
                        poprawny = false;
                        break;
                    }
                }
            }
            else
            {
                poprawny = false;
            }    

            return poprawny;
        }

        public static bool PoprawnyPin(string pin)
        {
            //sklada sie z 4 cyfr
            bool prawda = true;
            if (pin.Length != 4)
            {
                prawda = false;
            }
            int x;
            if(int.TryParse(pin, out x) == false)
            {
                prawda = false;
            }

            return prawda;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj adres email");
            string email = Console.ReadLine();
            Console.WriteLine(PoprawnyEmail(email) ? "OK" : "Niepoprawny");
            Console.WriteLine(Regex.IsMatch(email, @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-z]{2,}$") ? "OK" : "Niepoprawny");
            //^[A-Z][a-z]+\s[A-Z][a-z]+$
            //^[0 - 9]{ 2}-[0 - 9]{ 3}$
        }

    }
}
