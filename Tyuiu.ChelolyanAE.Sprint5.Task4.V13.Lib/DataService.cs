using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChelolyanAE.Sprint5.Task4.V13.Lib
{
    public class DataService : ISprint5Task4V13
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            string s = str.Replace(".", ",");
            double x = Convert.ToDouble(s);
            double res = Math.Round(Math.Cos(x) + (Math.Pow(x, 2) / 2), 3);
            return res;
        }
    }
}
