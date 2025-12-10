using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerezovskiyAS.Sprint6.Task1.V7.Lib
{
    public class DataService : ISprint6Task1V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mass = { 7.76, 7.36, 7.26, 7.9, 15.88, 2.0, 4.35, 5.63, 6.49, 6.49, 6.32 };
            return mass;
        }
    }
}
