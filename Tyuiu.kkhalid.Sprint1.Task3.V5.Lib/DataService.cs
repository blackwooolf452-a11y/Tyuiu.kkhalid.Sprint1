using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.Kkhalid.Sprint1.Task3.V5.Lib
{
    public class DataService : ISprint1Task3V5
    {
        public double DistanceLength(double mapScale, double distanceOnMap)
        {
            // Вычисляем реальное расстояние и округляем до 3 знаков после запятой
            double result = mapScale * distanceOnMap;
            return System.Math.Round(result, 3);
        }
    }
}