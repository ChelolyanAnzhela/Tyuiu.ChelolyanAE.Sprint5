using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.ChelolyanAE.Sprint5.Task7.V20.Lib
{
    public class DataService : ISprint5Task7V20
    {
        public string LoadDataAndSave(string path)
        {
            string Savepath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V20.txt");
            FileInfo fileInfo = new FileInfo(Savepath);
            if (fileInfo.Exists)
            {
                File.Delete(Savepath);
            }
            string str = File.ReadAllText(path);
            

            bool LastChar = false;
            string s = "";
            foreach (char chr in str)
            {
                if ((chr == 'с') || (chr == 'С'))
                {
                    if (LastChar == true)
                    {
                        LastChar = false;
                    }
                    else
                    {
                        LastChar = true;
                        s += 'с';
                    }
                }
                else
                {
                    LastChar = false;
                    s += chr;
                }
            }
            File.AppendAllText(Savepath, s);
            return Savepath;
        }
        
    }
}
