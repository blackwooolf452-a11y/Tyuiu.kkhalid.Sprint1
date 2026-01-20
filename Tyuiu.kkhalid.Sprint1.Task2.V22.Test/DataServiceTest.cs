using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Kkhalid.Sprint1.Task2.V22.Lib;

namespace Tyuiu.Kkhalid.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateAVGValue()
        {
            DataService ds = new DataService();
            int a = 10;
            int b = 20;
            int c = 30;
            int wait = (10 + 20 + 30) / 3; // 60 / 3 = 20
            int res = ds.CalculateAVGValue(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}