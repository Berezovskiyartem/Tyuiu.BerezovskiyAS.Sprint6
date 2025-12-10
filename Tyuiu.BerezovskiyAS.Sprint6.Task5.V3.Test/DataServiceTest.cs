using Tyuiu.BerezovskiyAS.Sprint6.Task5.V3.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint6.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string testFile = "InPutDataFileTask5V3.txt";

            double[] expectedNumbers = {
                -1.61,
                -3.53,
                15.29,
                13.08,
                9.54,
                -8.66,
                13.31,
                6.41,
                17.04,
                -7.14,
                6.77,
                17.01
            };

            double[] actualNumbers = ds.LoadFromDataFile(testFile);

            Assert.AreEqual(expectedNumbers.Length, actualNumbers.Length);
        }
    }
}
