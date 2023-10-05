using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2_Legenchenko
{
    // Базовый абстрактный класс Shape
    public abstract class Shape
    {
        // Абстрактный метод для вычисления площади
        public abstract double Area();

        // Абстрактный метод для вычисления периметра
        public abstract double Perimeter();
    }

    // Класс Circle, производный от Shape
    public class Circle : Shape
    {
        private double radius; // радиус круга

        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Переопределение метода Area() для круга
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Переопределение метода Perimeter() для круга
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    // Класс Rectangle, производный от Shape
    public class Rectangle : Shape
    {
        private double width;  // ширина прямоугольника
        private double height; // высота прямоугольника

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Переопределение метода Area() для прямоугольника
        public override double Area()
        {
            return width * height;
        }

        // Переопределение метода Perimeter() для прямоугольника
        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(8);  // Создание объекта класса Circle
            Console.WriteLine($"Площадь круга: {circle.Area()}, Периметр круга: {circle.Perimeter()}");

            Rectangle rectangle = new Rectangle(3, 8);  // Создание объекта класса Rectangle
            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}, Периметр прямоугольника: {rectangle.Perimeter()}");
        }
    }
}
