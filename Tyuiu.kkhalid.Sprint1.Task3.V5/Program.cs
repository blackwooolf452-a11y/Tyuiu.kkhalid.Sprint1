using System;
using Tyuiu.Kkhalid.Sprint1.Task3.V5.Lib;

namespace Tyuiu.Kkhalid.Sprint1.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Масштаб карты (количество км в одном см) ->");
            double mapScale = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Расстояние между точками на карте (см) ->");
            double distanceOnMap = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.DistanceLength(mapScale, distanceOnMap);
            Console.WriteLine($"* Расстояние между населенными пунктами = {result} км.                  *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}