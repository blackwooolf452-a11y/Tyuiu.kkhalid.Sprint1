using System;
using Tyuiu.Kkhalid.Sprint1.Task4.V25.Lib;

namespace Tyuiu.Kkhalid.Sprint1.Task4.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите угол α в градусах:");
            double alpha = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(alpha);
            Console.WriteLine($"* (1 - cos α) / sin² α = {result}                                         *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}