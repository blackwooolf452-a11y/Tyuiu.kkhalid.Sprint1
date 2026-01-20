using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Kkhalid.Sprint1.Task1.V25.Lib;

namespace Tyuiu.Kkhalid.Sprint1.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            double wait = (x * y) / (1 + x); // (2*3)/(1+2) = 6/3 = 2
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}