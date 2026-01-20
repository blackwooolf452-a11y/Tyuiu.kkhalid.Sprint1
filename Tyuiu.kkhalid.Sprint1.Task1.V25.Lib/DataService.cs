using System;

namespace Tyuiu.Kkhalid.Sprint1.Task1.V25.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            // Вычисляем выражение: (x * y) / (1 + x)
            return (x * y) / (1 + x);
        }
    }
}