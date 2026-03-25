using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerezovskiyAS.Sprint6.Task1.V7.Lib
{
    public class DataService : ISprint6Task1V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[Math.Abs(startValue) + Math.Abs(stopValue) + 1];
            for (int i = 0; i < res.Length; i++)
            {
                int j = i - 5;
                if ((Math.Cos(j) + j) == 0)
                {
                    res[i] = 0;
                    continue;
                }
                res[i] = Math.Round((2 * j - 3) / (Math.Cos(j) + j) + 5, 2);
            }
            return res;
        }
    }
}
