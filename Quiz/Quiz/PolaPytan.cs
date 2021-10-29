using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class PolaPytan
    {


        List<string> pytania = new List<string>();
        List<string> odpowiedzi = new List<string>();

        public void DodajPytanie()
        {
            string info = File.ReadAllText(@"C:\Users\huber\OneDrive\Desktop\Quizquestions.txt");
            string[] questions = info.Split("\n");
            foreach (var question in questions)
            {
                string[] SingleQuestion = question.Split(";");
                for (int i = 0; i < SingleQuestion.Length; i++)
                {
                    if (i != 5)
                    {
                        pytania.Add(SingleQuestion[i]);
                    }
                    if (i == 5)
                    {
                        odpowiedzi.Add(SingleQuestion[i]);
                    }    
                }
            }
        }

        public void Losuj()
        {
            Random rnd = new Random();
            int RandomQuestion = rnd.Next(0, pytania.Count);
            Console.WriteLine(pytania[RandomQuestion]);
            int Input = int.Parse(Console.ReadLine());

        }


        public override string ToString()
        {
            string wynik = string.Empty;
            for (int i = 0; i < pytania.Count; i++)
            {
                wynik += pytania[i] + "\n";
            }
            for (int i = 0; i < odpowiedzi.Count; i++)
            {
                wynik += odpowiedzi[i] + "\n";
            }
            return wynik;
        }
    }
}
