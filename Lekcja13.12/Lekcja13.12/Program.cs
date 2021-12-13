using System;

namespace Lekcja13._12
{
    class Program
    {
        static event Action otwarcieOkna; //event jest zbiorem funkcji ktore wywolaja sie w momencie jego uruchomienia
        //typ funkcji okreslany jest przez slowo ktore znajduje sie przed nazwa (w tym przypadku Action)

        static void WlaczAlarm()
        {
            Console.WriteLine("Alarm.......................");
        }

        static void ZapalSwiatlo()
        {
            Console.WriteLine("Swiatlo zostalo zapalone");
        }

        static void Hello()
        {
            Console.WriteLine("Hello world");
        }

        static void Dodaj(int a, int b)
        {
            Console.WriteLine($"Wynik to: {a+b}");
        }
        static void Odejmij(int a, int b)
        {
            Console.WriteLine($"Wynik to: {a - b}");
        }

       static int Dodawanie(int a, int b)
        {
            return a + b;
        }

        static int Odejmowanie(int a, int b)
        {
            return a - b;
        }

        static int Mnozenie(int a, int b)
        {
            return a * b;
        }

        static bool czyNajnowszy(Book b)
        {
            return b.Rok == 2021;
        }

        delegate int Operacja(int a, int b); //delegazione di tipo int con due argomenti

        static void Main(string[] args)
        {
            Action ac = Hello; //ten Action przechowuje tylko bezargumeotwe funkcje bez typu zwracanego (void)
            ac();

            /*Action<int, int> func = Dodaj; // action con argomenti senza tipo (static void)
            func(10, 20);
            func = Odejmij;
            func(10, 20);

            Func<int, int, int> operacja = Dodawanie; // func conserva la funzione con valore di ritorno e argomenti
            Console.WriteLine(operacja(10, 20));

            Console.WriteLine();
            Func<int, int, int>[] operacje = new Func<int, int, int>[]
            {
                Dodawanie, 
                Odejmowanie, 
                Mnozenie, 
                (a, b) => a/b, 
                (a, b) => (int)Math.Pow(a ,b)
            };
            Console.WriteLine("Podaj liczbe nr 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe nr 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe numer operacji");
            int nr = int.Parse(Console.ReadLine());
            Console.WriteLine(operacje[nr](a, b));*/
            
            BookList bookList = new BookList();
            Book b1 = new Book("Andrzej", 2021, "Forest");
            Book b2 = new Book("Michal", 2011, "Blue sea");
            Book b3 = new Book("Rafal", 2018, "At home");
            Book b4 = new Book("Hubert", 2017, "Adventure");

            bookList.Dodaj(b1);
            bookList.Dodaj(b2);
            bookList.Dodaj(b3);
            bookList.Dodaj(b4);

            Console.WriteLine(bookList.Szukaj("Forest")); 
            Console.WriteLine(bookList.Szukaj(czyNajnowszy)); 
            Console.WriteLine(bookList.Szukaj(b => b.Author == "Rafal")); //to w srodku to wyrazenie lambda tzw funkcja anonimowa 

            Action hey = () => Console.WriteLine("Hello world");
            hey();

            Operacja[] operacje = new Operacja[]
            {
                Dodawanie,
                Odejmowanie,
                Mnozenie,
                (a, b) => a/b, //to w srodku to wyrazenie lambda tzw funkcja anonimowa 
                (a, b) => (int)Math.Pow(a ,b) //to w srodku to wyrazenie lambda tzw funkcja anonimowa 
            };

            //podpinanie funkcji pod event
            otwarcieOkna += WlaczAlarm;
            otwarcieOkna += ZapalSwiatlo;

            otwarcieOkna(); //wywolanie eventu i wywolanie funkcji podpietych pod niego
        }
    }
}
