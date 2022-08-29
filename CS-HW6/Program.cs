using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW6
{
    public delegate double Fun(double a, double x);
    class Program
    {
        //Метод, принимающий делегат
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- A ------- X -------- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("-----------------------------------");
        }

        //Метод возвращает значение функции a*x^2
        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

        //Метод возвращает значение функции a*sin(x)
        public static double MySin(double a, double x)
        {
            return a * Math.Sin(x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Домашняя работа. Урок 6");
            Console.WriteLine($"Студент: Ыбыраев Канат");
            Console.WriteLine("=====================================================================");
            Console.WriteLine();
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции a*x^2:");

            Table(new Fun(MyFunc), -9.3, -3, 5);

            Console.WriteLine("Таблица функции a*sin(x):");
            Table(new Fun(MyFunc), 8, -7, 1);

            Console.ReadKey();
        }
    }
}
