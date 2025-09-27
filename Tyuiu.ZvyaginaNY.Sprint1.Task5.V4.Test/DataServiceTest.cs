using Tyuiu.ZvyaginaNY.Sprint1.Task5.V4.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSecondsToHours()
        {
            DataService ds = new DataService();
            int k = 13257;
            int wait = 3; 
            int res = ds.SecondsToHours(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ZeroSeconds()
        {
            DataService ds = new DataService();
            int k = 0;
            int wait = 0;
            int res = ds.SecondsToHours(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ExactlyOneHour()
        {
            DataService ds = new DataService();
            int k = 3600;
            int wait = 1;
            int res = ds.SecondsToHours(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void LessThanOneHour()
        {
            DataService ds = new DataService();
            int k = 3599;
            int wait = 0; 
            int res = ds.SecondsToHours(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void FullDay()
        {
            DataService ds = new DataService();
            int k = 86400;
            int wait = 24; 
            int res = ds.SecondsToHours(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void AlmostFullDay()
        {
            DataService ds = new DataService();
            int k = 86399;
            int wait = 23; 
            int res = ds.SecondsToHours(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void NegativeSeconds_ShouldThrowException()
        {
            DataService ds = new DataService();
            int k = -100;
            Assert.ThrowsException<ArgumentException>(() => ds.SecondsToHours(k));
        }

        [TestMethod]
        public void MoreThanDay_ShouldThrowException()
        {
            DataService ds = new DataService();
            int k = 100000;
            Assert.ThrowsException<ArgumentException>(() => ds.SecondsToHours(k));
        }

        [TestMethod]
        public void BoundaryValues()
        {
            DataService ds = new DataService();

            
            Assert.AreEqual(0, ds.SecondsToHours(0));
            Assert.AreEqual(0, ds.SecondsToHours(3599));
            Assert.AreEqual(1, ds.SecondsToHours(3600));
            Assert.AreEqual(1, ds.SecondsToHours(7199));
            Assert.AreEqual(2, ds.SecondsToHours(7200));

            
            Assert.AreEqual(23, ds.SecondsToHours(82799));
            Assert.AreEqual(23, ds.SecondsToHours(86399));
            Assert.AreEqual(24, ds.SecondsToHours(86400));
        }
    }
}