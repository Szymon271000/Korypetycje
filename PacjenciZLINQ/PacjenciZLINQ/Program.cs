using System;

namespace PacjenciZLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            BazaPacjentow p1 = new BazaPacjentow();
            Pacjent pacjent1 = new Pacjent("Jan", "Kowalski", "12345678910", "fdgfddf", 65);
            Pacjent pacjent2 = new Pacjent("Michal", "Kowalski", "46578904321", "tyuyjh", 35);
            Pacjent pacjent3 = new Pacjent("Adam", "Kowalski", "68907532759", "", 65);
            p1.Add(pacjent1);
            p1.Add(pacjent2);
            p1.Add(pacjent3);

            p1.Pokaz();
            Console.WriteLine();
            p1.StarsiNiz(64);
            Console.WriteLine(p1.Znajdz("Jan", "Kowalski"));
            Console.WriteLine(p1.PoliczNieubezpieczonych());

        }
    }
}
