using Tyuiu.ZvyaginaNY.Sprint1.Task7.V24.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0.5;
            double wait = -0.333; 
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void CalculateWithPositiveValues()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 0.3;
            double wait = 1.0 / Math.Sin(15 * 0.3 - 4) * (1 + Math.Cos(Math.Sqrt(4)));
            wait = Math.Round(wait, 3);
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void CalculateWithNegativeX()
        {
            DataService ds = new DataService();
            double x = -0.5;
            double y = 0.4;
            double wait = 1.0 / Math.Sin(15 * 0.4 - 4) * (1 + Math.Cos(Math.Sqrt(0.5)));
            wait = Math.Round(wait, 3);
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void CalculateWithXMinusOne()
        {
            DataService ds = new DataService();
            double x = -1;
            double y = 0.2;
            double wait = 1.0 / Math.Sin(15 * 0.2 - 4) * (1 + Math.Cos(0));
            wait = Math.Round(wait, 3);
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void CalculateWithZeroDenominator_ShouldThrowException()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = (4 + Math.PI) / 15; 
            Assert.ThrowsException<DivideByZeroException>(() => ds.Calculate(x, y));
        }

        [TestMethod]
        public void CalculateWithNegativeUnderRoot_ShouldThrowException()
        {
            DataService ds = new DataService();
            double x = -2;
            double y = 0.5;
            Assert.ThrowsException<ArgumentException>(() => ds.Calculate(x, y));
        }

        [TestMethod]
        public void CalculateWithLargeValues()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 1;
            double wait = 1.0 / Math.Sin(15 * 1 - 4) * (1 + Math.Cos(Math.Sqrt(11)));
            wait = Math.Round(wait, 3);
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void CalculateWithPrecisionCheck()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0.5;

            
            double sqrtVal = Math.Sqrt(2);
            double cosVal = Math.Cos(sqrtVal);
            double numerator = 1 + cosVal;
            double denominator = Math.Sin(15 * 0.5 - 4);
            double expected = Math.Round(numerator / denominator, 3);

            double result = ds.Calculate(x, y);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}