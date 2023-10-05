using System;

namespace Zad_3_var_1_Legenchenko
{
    // Абстрактный класс для геометрической фигуры
    public abstract class Shape
    {
        // Метод для вычисления площади
        public abstract double Area();

        // Метод для вычисления периметра
        public abstract double Perimeter();
    }

    // Класс для круга
    public class Circle : Shape
    {
        // Радиус круга
        public double Radius { get; set; }

        // Переопределение метода для вычисления площади круга
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        // Переопределение метода для вычисления периметра круга
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    // Класс для прямоугольника
    public class Rectangle : Shape
    {
        // Ширина прямоугольника
        public double Width { get; set; }

        // Высота прямоугольника
        public double Height { get; set; }

        // Переопределение метода для вычисления площади прямоугольника
        public override double Area()
        {
            return Width * Height;
        }

        // Переопределение метода для вычисления периметра прямоугольника
        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }
    }

    // Класс для треугольника
    public class Triangle : Shape
    {
        // Основание треугольника
        public double Base { get; set; }

        // Высота треугольника
        public double Height { get; set; }

        // Сторона A треугольника
        public double SideA { get; set; }

        // Сторона B треугольника
        public double SideB { get; set; }

        // Переопределение метода для вычисления площади треугольника
        public override double Area()
        {
            return 0.5 * Base * Height;
        }

        // Переопределение метода для вычисления периметра треугольника
        public override double Perimeter()
        {
            return Base + SideA + SideB;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle { Radius = 5 };  // Создание объекта круга и инициализация радиуса 
            Console.WriteLine($"Circle: Area = {circle.Area()}, Perimeter = {circle.Perimeter()}");  // Вывод площади и периметра круга

            Rectangle rectangle = new Rectangle { Width = 4, Height = 5 };  // Создание объекта прямоугольника и инициализация ширины и высоты 
            Console.WriteLine($"Rectangle: Area = {rectangle.Area()}, Perimeter = {rectangle.Perimeter()}");  // Вывод площади и периметра прямоугольника

            Triangle triangle = new Triangle { Base = 3, Height = 4, SideA = 5, SideB = 6 };  // Создание объекта треугольника и инициализация основания, высоты и сторон 
            Console.WriteLine($"Triangle: Area = {triangle.Area()}, Perimeter = {triangle.Perimeter()}");  // Вывод площади и периметра треугольника 
        }
    }
}
