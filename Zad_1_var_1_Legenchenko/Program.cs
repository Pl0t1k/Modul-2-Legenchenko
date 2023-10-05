using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_1_var_1_Legenchenko
{
    // Определение класса "Студент"
    public class Студент
    {
        // Свойства класса
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public int Возраст { get; set; }
        public double СреднийБалл { get; set; }

        // Конструктор класса
        public Студент(string имя, string фамилия, int возраст, double среднийБалл)
        {
            Имя = имя;
            Фамилия = фамилия;
            Возраст = возраст;
            СреднийБалл = среднийБалл;
        }

        // Метод для вывода информации о студенте
        public override string ToString()
        {
            return $"Студент: {Имя} {Фамилия}, Возраст: {Возраст}, Средний балл: {СреднийБалл}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляров класса "Студент"
            Студент студент1 = new Студент("Иван", "Иванов", 20, 4.5);
            Студент студент2 = new Студент("Петр", "Петров", 21, 4.7);

            // Вывод информации о студентах
            Console.WriteLine(студент1.ToString());
            Console.WriteLine(студент2.ToString());
        }
    }
}
