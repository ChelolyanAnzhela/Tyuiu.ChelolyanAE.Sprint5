using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChelolyanAE.Sprint5.Task0.V9.Lib
{
    public class DataService : ISprint5Task0V9
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double res = Math.Round((Math.Pow(x, 3)) / (Math.Pow(x, 2) - 1), 3);
            File.WriteAllText(path, Convert.ToString(res));
            return path;
        }
    }
}
