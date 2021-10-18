using System;
using System.Collections.Generic;

namespace Lekcja18._10
{
    class Program
    {
        class MojaKlasa
        {

        }
        static void Main(string[] args)
        {
            object x = new Random(); //rzutowanie w góre
            Console.WriteLine(x);
            Random r = (Random)x; //rzutowanie w dol
            Console.WriteLine(r.Next(0, 9));

            //MojaKlasa zmienna = (MojaKlasa)x; //blad krytyczny bo random nie jest typu MojaKlasa

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            List<Operacja> operacjas = new List<Operacja>();
            Dzielenie divide = new Dzielenie(a,b);
            Mnozenie multiply = new Mnozenie(a, b);
            Dodawanie addition = new Dodawanie(a, b);
            operacjas.Add(divide);
            operacjas.Add(multiply);
            operacjas.Add(addition);

            for (int i = 0; i < operacjas.Count; i++)
            {
                int operacja = operacjas[i].Wykonaj();
                string nazwa = operacjas[i].ToString();
                Console.WriteLine(nazwa + " :"+ operacja);
            }

            //Operacja o = new Operacja(5 , 10); //tego nie mozna bo Operacja jest abstract
            //Operacja op = new Dodawanie(5, 10); //zmienna moge stowrzyc tego typu
            
        }
    }
}
