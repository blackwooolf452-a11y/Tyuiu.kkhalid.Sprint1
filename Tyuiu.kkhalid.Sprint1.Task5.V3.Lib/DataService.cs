using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyyiu.Kkhalid.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            // Получаем третью цифру с конца числа k
            // Пример: k = 130985
            // 1. k / 100 = 1309 (отбрасываем две последние цифры)
            // 2. 1309 % 10 = 9 (получаем последнюю цифру оставшегося числа)

            int temp = k / 100;      // Убираем две последние цифры
            int result = temp % 10;  // Берём последнюю цифру

            return result;
        }
    }
}