using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework_Lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант2
            Console.WriteLine("Введите значение а :");
            double a = Double.Parse(Console.ReadLine().Trim().Replace(".",","));
            Console.WriteLine("Введите значение b :");
            double b = Double.Parse(Console.ReadLine().Trim().Replace(".", ","));
            Console.WriteLine("Введите значение c :");
            double c = Double.Parse(Console.ReadLine().Trim().Replace(".", ","));
            Console.WriteLine("Введите значение d :");
            double d = Double.Parse(Console.ReadLine().Trim().Replace(".", ","));

            Double x1 = (a / c)*(b/d);
            double x2 = (a * b - c)/(c*d);
            double x = x1 - x2;
            Console.WriteLine($"Результат вычислений : {x}");
            Console.ReadLine();


            // вариант 6
            Console.WriteLine("Введите значение x :");
             x = Double.Parse(Console.ReadLine().Trim().Replace(".", ","));
            double y = x - Math.Pow(x, 3) / 3 + Math.Pow(x, 5) / 5;
            Console.WriteLine($"Результат вычислений : {y}");
            Console.ReadLine();

            //Вариант 12
            Console.WriteLine("Введите значение x :");
            x = Double.Parse(Console.ReadLine().Trim().Replace(".", ","));
            y = (Math.Pow(x, 2) - x * 7 + 10) / (Math.Pow(x, 2) - x * 8 + 12);
            Console.WriteLine($"Результат вычислений : {y}");
            Console.ReadLine();


            //Вариант 13
            Console.WriteLine("Введите значение x :");
            x = Double.Parse(Console.ReadLine().Trim().Replace(".", ","));
            Console.WriteLine("Введите значение y :");
            y = Double.Parse(Console.ReadLine().Trim().Replace(".", ","));
            double z = Math.Cos(x) / (Math.PI - x * 2) + 16 * x * Math.Cos(x * y) - 2;
            Console.WriteLine($"Результат вычислений : {z}");
            Console.ReadLine();

            //Вариант 35

            Console.WriteLine("Введите значение R :");
            double R = Double.Parse(Console.ReadLine().Trim().Replace(".", ","));
            x = 2 * Math.PI * R;
            Console.WriteLine($"Результат вычислений : {x}");
            Console.ReadLine();

            Console.WriteLine(x2);
            Console.ReadLine();


        }
    }
}
