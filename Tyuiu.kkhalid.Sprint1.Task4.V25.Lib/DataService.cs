using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Kkhalid.Sprint1.Task4.V25.Lib
{
    public class DataService : ISprint1Task4V25
    {
        public double Calculate(double alpha)
        {
            // Перевод угла из градусов в радианы
            double radians = alpha * Math.PI / 180;

            // Вычисление по формуле: (1 - cos α) / sin² α
            double numerator = 1 - Math.Cos(radians);
            double denominator = Math.Pow(Math.Sin(radians), 2);

            double result = numerator / denominator;

            // Округление до 3 знаков после запятой
            return Math.Round(result, 3);
        }
    }
}