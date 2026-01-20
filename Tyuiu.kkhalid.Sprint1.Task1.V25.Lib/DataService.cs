using System;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.Kkhalid.Sprint1.Task1.V25.Lib
{
    public class DataService : ISprint1Task1V25
    {
        public double Calculate(double x, double y)
        {
            // Вычисляем выражение: (x * y) / (1 + x)
            return Math.Round(2) (x * y) / (1 + x);
        }
    }
}