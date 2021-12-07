using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasilev14
{
    internal class Test
    {
        public delegate int Mydel (Book a, Book b);
        public Test()
        {
            Book a = new Book("asas","asasa","asa");
            Book b = new Book("asas", "asassa", "asa");
            
            Mydel mydel = new Mydel(Book.SortByName);
            mydel(a, b);
            BooksLibrary.LibrarySort(mydel);
            Comparison<Mydel>.CreateDelegate( , Book.SortByPublisher);
        }
        static void asasa() 
        {

        }
    }
    
    internal static class BooksLibrary
    {
        private static List<Book> books = new List<Book>();
        public static void AddBook(Book book) {books.Add(book);}
        public static void RemoveBook(Book book) { books.Remove(book);}
        public static List<Book> GetList() { return books; }

        public static void LibrarySort(Delegate mydelegate) 
        { 
            books.Sort();
        }
        
    }

    internal class Book
    {
        public string Name { get; private set; }
        public string Author { get; private set; }
        public string Publisher { get; private set; }

        public Book(string name, string author, string publisher)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
        }
        public static int SortByName(Book a, Book b)
        {
            return string.Compare(a.Name, b.Name);
        }

        public static int SortByAuthor(Book a, Book b)
        {
            return string.Compare(a.Author, b.Author);
        }

        public static int SortByPublisher(Book a, Book b)
        {
            return string.Compare(a.Publisher, b.Publisher);
        }
    }
}
