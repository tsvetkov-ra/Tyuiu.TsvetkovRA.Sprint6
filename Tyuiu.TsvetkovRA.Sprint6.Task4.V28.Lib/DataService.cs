using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TsvetkovRA.Sprint6.Task4.V28.Lib
{
    public class DataService : ISprint6Task4V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int x = stopValue - startValue + 1;
            double[] res = new double[x];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double y = Math.Round((Math.Cos(2 * i)) + ((Math.Sin(i)) / (i + 2.5)) + (2 * i), 2);
                res[count] = y;
                count++;

            }
            return res;
        }
    }
}
