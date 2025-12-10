using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerezovskiyAS.Sprint6.Task0.V4.Lib
{
    public class DataService : ISprint6Task0V4
    {
        public double Calculate(int x)
        {
            return Math.Round(2.4 * Math.Pow(x, 3) + 0.4 * Math.Pow(x, 2) - 1.4 * x + 4.1, 3);
        }
    }
}
