using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TsvetkovRA.Sprint6.Task2.V20.Lib
{
    public class DataService : ISprint6Task2V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++) count++;

            double[] mass = new double[count];
            int k = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                if (i + 1.2 == 0)
                {
                    mass[k] = 0;
                    continue;
                }

                mass[k] = Math.Round((Math.Sin(i) / (i + 1.2)) - Math.Sin(i) * 2 - 2 * i, 2);
                k++;
            }
            return mass;
        }
    }
}
