using System;
using Tyuiu.Kkhalid.Sprint1.Task0.V29.Lib;

namespace Tyuiu.Kkhalid.Sprint1.Task0.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 2 * 9 + 7 * 2                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* {ds.Calculate()}                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}