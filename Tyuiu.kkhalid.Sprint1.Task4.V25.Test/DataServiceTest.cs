using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Kkhalid.Sprint1.Task4.V25.Lib;

namespace Tyuiu.Kkhalid.Sprint1.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double alpha = 45; // угол в градусах
            double radians = alpha * System.Math.PI / 180;
            double wait = (1 - System.Math.Cos(radians)) / System.Math.Pow(System.Math.Sin(radians), 2);
            wait = System.Math.Round(wait, 3);
            double res = ds.Calculate(alpha);
            Assert.AreEqual(wait, res);
        }
    }
}