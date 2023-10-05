using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Пространство имен для вашего проекта
namespace Zad_1_Legenchenko
{
    // Определение класса Person
    public class Person
    {
        // Приватные поля класса Person
        private string name;
        private int age;
        private string address;

        // Свойства для доступа к приватным полям
        public string Name
        {
            get { return name; }  // Возвращает имя
            set { name = value; } // Устанавливает имя
        }

        public int Age
        {
            get { return age; }   // Возвращает возраст
            set { age = value; }  // Устанавливает возраст
        }

        public string Address
        {
            get { return address; }   // Возвращает адрес
            set { address = value; }  // Устанавливает адрес
        }

        // Конструктор класса Person, принимающий имя, возраст и адрес
        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
    }

    // Определение класса Program
    internal class Program
    {
        // Точка входа в программу
        static void Main(string[] args)
        {
            // Создание объектов класса Person и инициализация их свойств
            Person person1 = new Person("Александр", 17, "Орша");
            Person person2 = new Person("Мария", 18, "Витебск");

            // Вывод информации о каждом объекте класса Person на консоль
            Console.WriteLine($"Имя: {person1.Name}, Возраст: {person1.Age}, Адрес: {person1.Address}");
            Console.WriteLine($"Имя: {person2.Name}, Возраст: {person2.Age}, Адрес: {person2.Address}");
        }
    }
}
