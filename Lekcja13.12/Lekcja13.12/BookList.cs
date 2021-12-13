using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja13._12
{
    class BookList
    {
        //jak stworzyc wlasny typ delegatowy
        public delegate bool Predykat(Book b); // qualsiasi delegato di tipo bool con argomento Book


        List<Book> books = new List<Book>();

        public void Dodaj (Book book)
        {
            books.Add(book);
        }

        public Book Szukaj(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    return books[i];
                }
            }
            return null;
        }

        public Book Szukaj(Predykat sprawdz)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (sprawdz(books[i]))
                {
                    return books[i];
                }
            }
            return null;
        }
    }
}
