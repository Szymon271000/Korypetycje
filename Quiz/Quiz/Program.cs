using System;
using System.Collections.Generic;
using System.IO;

namespace Quiz
{
    class Program
    {

        static void Main(string[] args)
        {
            PytaniaRepository pytania = new PytaniaRepository();
            pytania.Wczytaj(@"C:\Users\huber\OneDrive\Desktop\Quizquestions.txt");

            int counter = 0;
            bool wynik = false;

            while (wynik == false)
            {
                Pytanie p = pytania.WylosujPytanie();
                Console.WriteLine(p); 
                int Input = int.Parse(Console.ReadLine());
                if(Input - 1 == p.PoprawnaNr)
                {
                    counter++;
                    Console.WriteLine("Poprawna odpowiedz");
                }
                else
                {
                    wynik = true;
                }
            }


            if (counter != 0)
            {
                Console.WriteLine($"Bledna odpowiedz. Poprawne odpowiedzi: {counter - 1}");
            }
            else
            {
                Console.WriteLine($"Bledna odpowiedz. Poprawne odpowiedzi: 0");
            }
        }
    }
}
