using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChelolyanAE.Sprint5.Task7.V20.Lib
{
    public class DataService : ISprint5Task7V20
    {
        public string LoadDataAndSave(string path)
        {
            string s="";

            string data = File.ReadAllText(path);
            bool LastChar = false;
            foreach (char chr in data)
            {

                if (chr == 'с')
                {
                    if (LastChar)
                    {
                        s += 'с';
                        LastChar = false;
                    }
                    else
                    {
                        LastChar = true;
                    }
                }
                else
                {
                    LastChar = false; 
                    s+= chr;
                }
            }
        }
    }
}
