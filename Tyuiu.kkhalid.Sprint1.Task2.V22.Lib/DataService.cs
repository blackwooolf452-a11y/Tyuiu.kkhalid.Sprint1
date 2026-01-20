using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.Kkhalid.Sprint1.Task2.V22.Lib
{
    public class DataService : ISprint1Task2V22
    {
 
        public int CalculateAVGValue(int a, int  b, int c)
        {
            // Вычисляем среднее арифметическое трёх чисел
            return (a + b + c) / 3;
        }
    }
}