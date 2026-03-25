using Tyuiu.BerezovskiyAS.Sprint6.Task3.V16.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint6.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int countRows = 5;
            int countColumns = 5;
            int[,] resultArray = new int[countRows, countColumns];
            int[,] array = { { 14, 1, -3, 1, 10},
                             { 7, -3, 5, -4, 0 },
                             { -10, -19, -18, -9, 19 },
                             { -2, -2, -16, 2, -17 },
                             { -16, 9, 5, -10, 16 } };
            int[,] arrayWait = { { 14, 1, -3, 1, 10},
                             { 7, -3, 5, -4, 0 },
                             { 0, -19, 0, -9, 19 },
                             { -2, -2, -16, 2, -17 },
                             { -16, 9, 5, -10, 16 } };
            resultArray = ds.Calculate(array);
            for (int i = 0; i < countRows; i++)
            {
                for (int j = 0; j < countColumns; j++)
                {
                    Assert.AreEqual(resultArray[i, j], arrayWait[i, j]);
                }
            }
        }
    }
}
