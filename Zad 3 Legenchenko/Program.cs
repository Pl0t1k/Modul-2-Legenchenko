using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3_Legenchenko
{
    // Класс Author, представляющий автора
    public class Author
    {
        // Свойства класса: имя и год рождения автора
        public string Name { get; set; }
        public int BirthYear { get; set; }

        // Конструктор класса Author
        public Author(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }
    }

    // Класс Book, представляющий книгу
    public class Book
    {
        // Свойства класса: название книги, год выпуска и автор
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public Author Author { get; set; }

        // Конструктор класса Book
        public Book(string title, int releaseYear, Author author)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Author = author;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов классов Author и Book
            Author author1 = new Author("Лев Толстой", 1828);
            Book book1 = new Book("Война и мир", 1869, author1);

            Author author2 = new Author("Александр Сергеевич Пушкин", 1799);
            Book book2 = new Book("Евгений Онегин", 1833, author2);

            // Вывод информации о книгах и их авторах
            Console.WriteLine($"Книга: {book1.Title}, Год выпуска: {book1.ReleaseYear}, Автор: {book1.Author.Name}, Год рождения автора: {book1.Author.BirthYear}");
            Console.WriteLine($"Книга: {book2.Title}, Год выпуска: {book2.ReleaseYear}, Автор: {book2.Author.Name}, Год рождения автора: {book2.Author.BirthYear}");
        }
    }
}
