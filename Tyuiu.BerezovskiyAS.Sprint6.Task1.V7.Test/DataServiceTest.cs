using Tyuiu.BerezovskiyAS.Sprint6.Task1.V7.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint6.Task1.V7.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res1 = { 7.76, 7.36, 7.26, 7.9, 15.88, 2, 4.35, 5.63, 6.49, 6.49, 6.32 };

            CollectionAssert.AreEqual(res1, ds.GetMassFunction(-5, 5));
        }
    }
}
