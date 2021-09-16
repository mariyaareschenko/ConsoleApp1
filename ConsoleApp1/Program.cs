using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2.1");
            Console.WriteLine("Введите свое имя");
            string name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, {0}!", name);

            Console.WriteLine("Задание 2.2");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num2 != 0)
                Console.WriteLine("Результат деления: " + num1 / num2);
            else
                Console.WriteLine("Ошибка");

            Console.WriteLine("Задание 2.2");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if (D < 0)
                Console.WriteLine("Нет решений");
            else if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0} x2 = {1}", x1, x2);
            }
            else if (D == 0)
            {
                double x = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x = " + x);
            }

            Console.ReadKey();

        }
    }
}
