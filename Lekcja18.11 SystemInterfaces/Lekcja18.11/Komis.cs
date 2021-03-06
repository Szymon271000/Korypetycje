using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18._11
{
    class Komis : IEnumerable<Car> //dzieki IEnumerable mozna uzywac obiektow klasy komis w foreach do iterowania pod liscie samochodow
    {
        List<Car> cars = new List<Car>();

        public void Add(Car c)
        {
            cars.Add(c);
        }

        public IEnumerable<Car> ByMarka(string marka)
        {
            foreach (var item in cars)
            {
                if(item.Marka == marka)
                {
                    yield return item; //yield return - zwraca wartosc a pozniej wraca z powrotem do tej funckji
                }
            }
        }
        public IEnumerator<Car> GetEnumerator()//IEnumerable
        {
            return cars.GetEnumerator();
        }

        public void Sortuj()
        {
            cars.Sort();
        }

        public void SortujPoNazwie()
        {
            cars.Sort(new CarNameComparer()); //podajemy sposob porownania
        }

        public override string ToString()
        {
            string wynik = string.Empty;
            for (int i = 0; i < cars.Count; i++)
            {
                wynik += cars[i] + "\n";
            }
            return wynik;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
