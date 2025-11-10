using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace con6_3_КорнееваАС
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметры фигуры (через пробел):");
            Console.WriteLine("1 число — квадрат, 2 — прямоугольник, 3 — трапеция");
            Console.WriteLine("Для выхода введите Q\n");

            while (true)
            {
                Console.Write(">>> ");
                string input = Console.ReadLine();

                // Проверка на выход: приводим к нижнему регистру и сравниваем с "q"
                if (input != null && input.ToLower() == "q")
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }

                // Разбиваем по пробелам (возможны пустые элементы)
                string[] parts = input.Split(' ');

                double[] numbers = new double[parts.Length];
                int count = 0;
                bool valid = true;

                foreach (string part in parts)
                {
                    // Пропускаем пустые или состоящие только из пробелов части
                    if (string.IsNullOrEmpty(part))
                        continue;

                    if (double.TryParse(part, out double value))
                    {
                        numbers[count] = value;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"Некорректное значение: '{part}'. Введите только числа.");
                        valid = false;
                        break;
                    }
                }

                if (!valid || count == 0)
                    continue;

                Figura figura = new Figura();

                if (count == 1)
                {
                    figura.ShowArea(numbers[0]);
                }
                else if (count == 2)
                {
                    figura.ShowArea(numbers[0], numbers[1]);
                }
                else if (count == 3)
                {
                    figura.ShowArea(numbers[0], numbers[1], numbers[2]);
                }
                else
                {
                    Console.WriteLine("Поддерживаются только 1, 2 или 3 параметра.");
                }
            }

            Console.ReadKey();
        }
    }

    class Figura
    {
        public void ShowArea(double a)
        {
            double area = a * a;
            Console.WriteLine($"Фигура: квадрат, сторона = {a}, площадь = {area:F2}");
        }

        public void ShowArea(double a, double b)
        {
            double area = a * b;
            Console.WriteLine($"Фигура: прямоугольник, стороны = {a} и {b}, площадь = {area:F2}");
        }

        public void ShowArea(double a, double b, double h)
        {
            double area = (a + b) / 2 * h;
            Console.WriteLine($"Фигура: трапеция, основания = {a} и {b}, высота = {h}, площадь = {area:F2}");
        }
    }
}
