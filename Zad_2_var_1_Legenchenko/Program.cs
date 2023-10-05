using System;
using System.Linq;


namespace Zad_2_var_1_Legenchenko
{
    // Определение структуры "Train"
    public struct Train
    {
        public string Destination; // Пункт назначения
        public int TrainNumber; // Номер поезда
        public DateTime DepartureTime; // Время отправления
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[5]; // Создание массива из 5 элементов типа "Train"

            // Ввод данных
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Введите данные для поезда {i + 1}:");
                Console.Write("Пункт назначения: ");
                trains[i].Destination = Console.ReadLine(); // Ввод пункта назначения

                Console.Write("Номер поезда: ");
                while (!int.TryParse(Console.ReadLine(), out trains[i].TrainNumber)) // Проверка ввода номера поезда
                {
                    Console.WriteLine("Ошибка! Введите корректный номер поезда.");
                    Console.Write("Номер поезда: ");
                }

                Console.Write("Время отправления (HH:mm): ");
                while (!DateTime.TryParseExact(Console.ReadLine(), "HH:mm", null, System.Globalization.DateTimeStyles.None, out trains[i].DepartureTime)) // Проверка ввода времени отправления
                {
                    Console.WriteLine("Ошибка! Введите корректное время отправления.");
                    Console.Write("Время отправления (HH:mm): ");
                }
            }

            // Сортировка по номеру поезда
            trains = trains.OrderBy(t => t.TrainNumber).ToArray();

            // Вывод информации о поезде по номеру
            Console.Write("\nВведите номер поезда: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number)) // Проверка ввода номера поезда
            {
                Console.WriteLine("Ошибка! Введите корректный номер поезда.");
                Console.Write("Введите номер поезда: ");
            }

            var train = trains.FirstOrDefault(t => t.TrainNumber == number);
            if (train.TrainNumber != 0)
                Console.WriteLine($"Пункт назначения: {train.Destination}, Время отправления: {train.DepartureTime.ToShortTimeString()}");

            // Сортировка по пункту назначения, затем по времени отправления
            trains = trains.OrderBy(t => t.Destination).ThenBy(t => t.DepartureTime).ToArray();
        }
    }
}
