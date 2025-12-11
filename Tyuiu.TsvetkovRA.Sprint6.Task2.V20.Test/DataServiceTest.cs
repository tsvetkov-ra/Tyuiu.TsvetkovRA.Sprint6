using Tyuiu.TsvetkovRA.Sprint6.Task2.V20.Lib;
namespace Tyuiu.TsvetkovRA.Sprint6.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int start = -1, stop = 1;

            int count = 0;
            for (int i = start; i <= stop; i++) count++;

            double[] mass = new double[count];
            mass[0] = -0.52;
            mass[1] = 0;
            mass[2] = -3.3;

            var res = ds.GetMassFunction(start, stop);

            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(mass[i], res[i]);
            }
        }
    }
}
