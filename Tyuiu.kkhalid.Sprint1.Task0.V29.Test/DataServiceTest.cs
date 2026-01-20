using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Kkhalid.Sprint1.Task0.V29.Lib;

namespace Tyuiu.Kkhalid.Sprint1.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate();
            double wait = 2 * 9 + 7 * 2; // 18 + 14 = 32
            Assert.AreEqual(wait, res);
        }
    }
}