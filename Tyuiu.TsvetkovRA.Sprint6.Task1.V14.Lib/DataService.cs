using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TsvetkovRA.Sprint6.Task1.V14.Lib
{
    public class DataService : ISprint6Task1V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Cos(x) + x) != 0)
                {
                    y = Math.Round((2 * x + 6) / (Math.Cos(x) + x) - 3, 2);
                }
                else
                {
                    y = 0;
                }
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
