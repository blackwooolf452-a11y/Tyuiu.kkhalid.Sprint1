using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyyiu.Kkhalid.Sprint1.Task5.V3.Lib;

namespace Tyyiu.Kkhalid.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int k = 130985;
            int wait = 9; // (130985 -> 1309 -> 9)
            int res = ds.Calculate(k);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();

            int k = 12345;
            int wait = 3; // (12345 -> 123 -> 3)
            int res = ds.Calculate(k);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();

            int k = 100;
            int wait = 1; // (100 -> 1 -> 1)
            int res = ds.Calculate(k);

            Assert.AreEqual(wait, res);
        }
    }
}