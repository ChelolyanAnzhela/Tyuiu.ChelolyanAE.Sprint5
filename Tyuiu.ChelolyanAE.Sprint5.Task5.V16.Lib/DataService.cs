using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChelolyanAE.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            double maxi = -1000000;
            using (StreamReader resder = new StreamReader(path))
            {
                string line;
                while ((line = resder.ReadLine()) != null)
                {
                    line = line.Replace(".", ",");
                    double[] a = line.Split(' ').Select(double.Parse).ToArray();
                    
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] == Math.Truncate(a[i]))
                        {
                            if (a[i] % 10 == 0 && a[i]!=0)
                            {
                                maxi=Math.Max(maxi, a[i]);
                              
                            }
                        }
                    }
                }
            }
            return maxi;
        }
    }
}
