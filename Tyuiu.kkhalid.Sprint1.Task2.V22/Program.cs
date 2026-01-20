using System;
using Tyuiu.Kkhalid.Sprint1.Task2.V22.Lib;

namespace Tyuiu.Kkhalid.Sprint1.Task2.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.CalculateAVG(a, b, c);
            Console.WriteLine($"* Среднее значение = {result}                                              *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}