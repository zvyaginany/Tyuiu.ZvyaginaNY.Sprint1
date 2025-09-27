using Tyuiu.ZvyaginaNY.Sprint1.Task4.V5.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 0.25; 
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CalculateWithNegativeX()
        {
            DataService ds = new DataService();
            double x = -3;
            double y = 9;
            double wait = 1.0 / 0; 
            Assert.ThrowsException<DivideByZeroException>(() => ds.Calculate(x, y));
        }

        [TestMethod]
        public void CalculateWithZeroY()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            double wait = 1.0; 
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CalculateWithDecimalResult()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0.414; 
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CalculateWithNegativeY_ShouldThrowException()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = -1;
            Assert.ThrowsException<ArgumentException>(() => ds.Calculate(x, y));
        }
    }
}