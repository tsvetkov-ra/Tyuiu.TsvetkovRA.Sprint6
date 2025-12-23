using Tyuiu.TsvetkovRA.Sprint6.Task6.V25.Lib;

namespace Tyuiu.MilyutinND.Sprint6.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V25.txt";

            string res = ds.CollectTextFromFile(path);
            string wait = "ELHLVt EgQpG dsE jiUFMDjMsEervIz ZujmucpYQE QybRwHOetJ";

            Assert.AreEqual(wait, res);
        }
    }
}