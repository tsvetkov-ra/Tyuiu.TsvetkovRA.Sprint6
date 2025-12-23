using Tyuiu.TsvetkovRA.Sprint6.Task7.V8.Lib;
namespace Tyuiu.TsvetkovRA.Sprint6.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask7V8.csv";

            int[,] res = ds.GetMatrix(path);

            int[,] wait =
            {
                { -14, -20, -20, 19, -1, -10, -8, -1, -4, -6 },
                { 17,6,6,4,-2,17,18,-1,1,-6 },
                { 16, 12, -17, -1, -11, 17, 15, -1, -3, 11 },
                { 12,-17,-18,-4,-1,3,13,-1,-2,10 },
                { -17,9,-10,-3,-16,-3,3,-1,11,16 },
                { -14,5,-1,-4,17,16,-9,5,-19,18 },
                { -12,-4,17,0,1,14,4,-1,13,-7 },
                { 15,-11,15,-14,20,12,-3,-1,-5,-8 },
                { 19,8,9,19,3,14,-1,15,-1,4 },
                { -5,-16,-12,18,-7,-5,-6,-1,10,0 },
            };
        }
    }
}