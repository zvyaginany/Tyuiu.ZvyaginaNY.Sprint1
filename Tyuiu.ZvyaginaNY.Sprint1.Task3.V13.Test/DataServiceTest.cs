using Tyuiu.ZvyaginaNY.Sprint1.Task3.V13.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 123;
            double wait = 6;
            var res = ds.MultiplyOfDigits(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void MultiplyOfDigits_NumberWithZero_ReturnsZero()
        {
            DataService ds = new DataService();
            double x = 102;
            double expected = 0;
            double result = ds.MultiplyOfDigits(x);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MultiplyOfDigits_AllOnes_ReturnsOne()
        {
            DataService ds = new DataService();
            double x = 111;
            double expected = 1;
            double result = ds.MultiplyOfDigits(x);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MultiplyOfDigits_LargeDigits_ReturnsCorrectValue()
        {
            DataService ds = new DataService();
            double x = 789;
            double expected = 504; 
            double result = ds.MultiplyOfDigits(x);
            Assert.AreEqual(expected, result);
        }
    }
}