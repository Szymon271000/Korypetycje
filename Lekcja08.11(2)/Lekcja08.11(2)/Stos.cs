using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja08._11_2_
{
    class Stos<T> //klasa generyczna
    {
        private List<T> lista = new List<T>();

        public void Push(T element)
        {
            lista.Add(element);
        }

        public T Peek()
        {
            return lista[lista.Count-1];
        }

        public T Pop()
        {
            T el = lista[lista.Count-1];
            lista.RemoveAt(lista.Count - 1);
            return el;
        }
    }
}
