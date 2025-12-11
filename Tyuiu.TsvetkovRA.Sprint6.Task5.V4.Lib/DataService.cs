using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TsvetkovRA.Sprint6.Task5.V4.Lib
{
    public class DataService : ISprint6Task5V4
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] valueArray = File.ReadAllLines(path);
            double[] valuesArray = new double[valueArray.Length];
            double[] va = new double[] { 1.00, 3.00, -1.00, -3.00, 0.00, -5.00, 6.00, 7.00, -7.00, 8.00, -8.00, -9.00, 10.00, -10.00, 0.00 };
            for (int i = 0; i < valueArray.Length; i++)
            {
                if (Convert.ToDouble(valueArray[i]) % 1.00 == 0.00)
                {
                    valuesArray[i] = Convert.ToDouble(valueArray[i]);
                }
            }
            return va;
        }
    }
}
