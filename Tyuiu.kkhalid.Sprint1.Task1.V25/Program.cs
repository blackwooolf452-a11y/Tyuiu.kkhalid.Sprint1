using System;
using Tyuiu.Kkhalid.Sprint1.Task1.V25.Lib;

namespace Tyuiu.Kkhalid.Sprint1.Task1.V25
{
    class Program
    {
        static void Main(string[] args)
        { 
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x, y);
            Console.WriteLine($"* {result}                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}