using Tyuiu.BerezovskiyAS.Sprint6.Task0.V4.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint6.Task0.V4.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 68.3;
            Assert.AreEqual(res, wait);
        }
    }
}
