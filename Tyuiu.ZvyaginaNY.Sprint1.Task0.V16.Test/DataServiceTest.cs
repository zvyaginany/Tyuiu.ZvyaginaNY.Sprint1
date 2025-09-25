using Tyuiu.ZvyaginaNY.Sprint1.Task1.V0.Lib;
namespace Tyuiu.ZvyaginaNY.Sprint1.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
