using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChelolyanAE.Sprint5.Task6.V22.Lib
{
    public class DataService : ISprint5Task6V22
    {
        public int LoadFromDataFile(string path)
        {
            
            int count = 0;
           
            string data = File.ReadAllText(path);
            bool LastChar = false;
            foreach (char chr in data)
            {
               
                if (chr == 'м')
                {
                    if (LastChar)
                    {
                        count++;
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
                }
            }

           
            
            return count;
        }
    }
}
