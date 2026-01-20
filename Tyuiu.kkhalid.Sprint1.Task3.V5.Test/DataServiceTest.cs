using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Kkhalid.Sprint1.Task3.V5.Lib;

namespace Tyuiu.Kkhalid.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDistanceLength()
        {
            DataService ds = new DataService();
            double mapScale = 120;
            double distanceOnMap = 3.5;
            double wait = 120 * 3.5; // 420
            double res = ds.DistanceLength(mapScale, distanceOnMap);
            Assert.AreEqual(wait, res);
        }
    }
}