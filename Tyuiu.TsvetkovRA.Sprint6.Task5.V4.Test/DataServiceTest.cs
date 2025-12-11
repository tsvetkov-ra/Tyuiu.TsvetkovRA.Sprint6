using Tyuiu.TsvetkovRA.Sprint6.Task5.V4.Lib;
namespace Tyuiu.TsvetkovRA.Sprint6.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = "C:\\DataSprint5\\Sprint6Task5\\InPutDataFileTask5V4.txt";
            double[] wait = new double[] { -1.00, 3.00, -1.00, -3.00, 0.00, -5.00, 6.00, 7.00, -7.00, 8.00, -8.00, -9.00, 10.00, -10.00, 0.00 };
            double[] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
