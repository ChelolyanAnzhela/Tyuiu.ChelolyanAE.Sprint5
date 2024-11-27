using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChelolyanAE.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist=fileInfo.Exists;
            if (fileExsist)
            {
                File.Delete(path);
            }
            double y;
            string str;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Round(2 * i - 4 + ((2 * i - 1) / (Math.Sin(i) + 1)), 2);
                str = Convert.ToString(y);
                if (i != stopValue)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
            }
            return (path);
        }
    }
}
