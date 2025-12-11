using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TsvetkovRA.Sprint6.Task3.V2.Lib
{
    public class DataService : ISprint6Task3V2
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[0, i] % 2 == 0)
                {
                    matrix[0, i] = 0;
                }
            }
            return matrix;
        }
    }
}
