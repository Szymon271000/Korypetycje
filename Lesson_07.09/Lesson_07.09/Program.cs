using System;
using System.IO;

namespace Lesson_07._09
{
    class Program
    {
        static void Main(string[] args)
        {
            char znak = 'x';
            Console.WriteLine(znak);

            char znak2 = (char)97; //zamienilem kod na literke i zapisalem w char
            Console.WriteLine(znak2);

            int literka = 'z';
            Console.WriteLine(literka); //ASCII table: https://www.asciitable.it/

            for (int i = 97; i <= 122; i++)
            {
                char z = (char)i;
                Console.Write($"{z} ");
            }
            Console.WriteLine();

            string zdanie = "ala ma kota";
            Console.WriteLine(zdanie);
            Console.WriteLine(zdanie[1]);
            Console.WriteLine(zdanie[4]);

            int spacje = 0;
            int maleLiterki = 0;
            for (int i = 0; i < zdanie.Length; i++)
            {
                if(zdanie[i] == ' ')
                {
                    spacje++;
                }
                if(Char.IsLower(zdanie[i])) //ISlower zwraca true jesli znak jest mala literka alfabetu
                {
                    maleLiterki++;
                }
            }
            Console.WriteLine($"Ilosc spacji: {spacje} małe literki: {maleLiterki}");

            //zdanie[0] = 'A'; //string jest typem niemutowalnym (immutable) - czyli nie mozna go zmienic

            string nowy = "A";
            for (int i = 1; i < zdanie.Length; i++)
            {
                nowy += zdanie[i]; //dodaje znak na koniec stringa
            }
            Console.WriteLine(nowy);

            Console.WriteLine("A" + zdanie.Substring(1)); //wez wszystkie znaki od 1 do konca
            Console.WriteLine(zdanie.Substring(7));
            Console.WriteLine(zdanie.Substring(4, 2)); //wez od 4 indeksu 2 literki

            string zamiana = zdanie.Replace("a", "o"); //tworzy nowy string w ktorym kazda literka a ze zdania zamienia sie na o
            Console.WriteLine(zamiana);

            string bezspacji = zdanie.Replace(" ", ""); //tworzy nowy string w ktorym kazda spacja jest zamieniana na brak znaku
            Console.WriteLine(bezspacji);

            //Split()
            string dane = Console.ReadLine(); //5,10,15,20
            string[] elementy = dane.Split(","); //przecinek jest separatorem przy dzieleniu wyrazu na mniejsze
            int[] liczby = new int[elementy.Length];
            for (int i = 0; i < elementy.Length; i++)
            {
                liczby[i] = int.Parse(elementy[i]);
            }

            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write(liczby[i] + " ");
            }
            Console.WriteLine();

            //Jak wczytac caly plik tekstowy jako jeden string
            string info = File.ReadAllText(@"C:\Users\huber\OneDrive\Desktop\dane.txt");
            Console.WriteLine(info);
            string[] linie = info.Split("\r\n");

            //Jak zapisac tekst do pliku?
            File.WriteAllText(@"C:\Users\huber\OneDrive\Desktop\wynik.txt", "Ala ma kota");
            File.WriteAllText(@"wynik.txt", "Ala ma kota"); //jesli nie podamy pelenj sciezki to plik stworzy sie tam gdzie wywolal sie plik exe naszej aplikacji

        }
    }
}
