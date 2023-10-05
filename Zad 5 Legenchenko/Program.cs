using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5_Legenchenko
{
    // Класс для представления датчика температуры
    public class TemperatureSensor
    {
        // Поле для хранения текущей температуры
        private double _temperature;

        // Делегат для события изменения температуры
        public delegate void TemperatureChangedHandler(double newTemperature);

        // Событие, которое происходит при изменении температуры
        public event TemperatureChangedHandler TemperatureChanged;

        // Свойство для доступа к текущей температуре
        public double Temperature
        {
            get { return _temperature; }
            set
            {
                // Если новое значение отличается от текущего,
                // обновляем значение и вызываем событие
                if (_temperature != value)
                {
                    _temperature = value;
                    TemperatureChanged?.Invoke(_temperature);
                }
            }
        }
    }

    // Класс для представления термостата
    public class Thermostat
    {
        // Поле для хранения состояния отопления (включено или выключено)
        private bool _heatingOn;

        // Метод, который вызывается при изменении температуры
        public void OnTemperatureChanged(double newTemperature)
        {
            // Если температура опускается ниже 20.0 градусов,
            // включаем отопление
            if (newTemperature < 20.0)
            {
                Console.WriteLine("Температура опустилась ниже 20.0 градусов. Включаем отопление.");
                _heatingOn = true;
            }
            // Если температура поднимается выше 25.0 градусов,
            // выключаем отопление
            else if (newTemperature > 25.0)
            {
                Console.WriteLine("Температура поднялась выше 25.0 градусов. Выключаем отопление.");
                _heatingOn = false;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр датчика температуры и термостата
            var sensor = new TemperatureSensor();
            var thermostat = new Thermostat();

            // Подписываемся на событие изменения температуры у датчика
            sensor.TemperatureChanged += thermostat.OnTemperatureChanged;

            // Изменяем температуру у датчика, что вызывает событие и,
            // следовательно, метод OnTemperatureChanged у термостата
            sensor.Temperature = 18.0;
            sensor.Temperature = 26.0;
        }
    }
}
