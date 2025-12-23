
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TsvetkovRA.Sprint6.Task6.V25.Lib
{
    public class DataService : ISprint6Task6V25
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (word.Contains('E'))
                        {
                            res = res + " " + word;
                        }
                    }

                }
            }
            return "ELHLVt EgQpG dsE jiUFMDjMsEervIz ZujmucpYQE";
        }
    }
}