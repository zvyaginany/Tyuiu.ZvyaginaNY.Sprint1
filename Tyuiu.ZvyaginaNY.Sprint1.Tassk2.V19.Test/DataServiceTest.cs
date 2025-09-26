using Tyuiu.ZvyaginaNY.Sprint1.Task2.V19.Lib;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task2.V19.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertInchToKm(x);
            Assert.AreEqual(0, 0508, res);
        }
    }
}
