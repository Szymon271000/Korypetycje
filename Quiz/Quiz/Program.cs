using System;
using System.IO;

namespace Quiz
{
    class Program
    {

        static void Main(string[] args)
        {
            string info = File.ReadAllText(@"C:\Users\huber\OneDrive\Desktop\Quizquestions.txt");
            string[] pytania = info.Split("\n");
            int counter = 0;
            bool wynik = false;
            Random rnd = new Random();
            while (wynik == false)
            {
                    int NumerLosowany = rnd.Next(0, pytania.Length);
                    string LosowanePytanie = pytania[NumerLosowany];
                    Console.WriteLine(LosowanePytanie); 
                    string Input = Console.ReadLine();

                    if (LosowanePytanie == pytania[0] && (Input != "2"))
                    {
                        wynik = true;
                    }
                    if (LosowanePytanie == pytania[1] && (Input != "1"))
                    {
                        wynik = true;
                    }
                    if (LosowanePytanie == pytania[2] && (Input != "1"))
                    {
                        wynik = true;
                    }
                    if (wynik == false)
                    {
                        Console.WriteLine("Poprawna odpowiedz");
                    }
                    counter++;                  
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
