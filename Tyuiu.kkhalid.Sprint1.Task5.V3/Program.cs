using System;
using Tyyiu.Kkhalid.Sprint1.Task5.V3.Lib;

namespace Tyyiu.Kkhalid.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите положительное целое число k:");
            int k = Convert.ToInt32(Console.ReadLine());

            if (k < 100)
            {
                Console.WriteLine("Число должно содержать минимум 3 цифры!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int h = ds.Calculate(k);
            Console.WriteLine($"* Третья цифра с конца числа {k} = {h}                                   *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}