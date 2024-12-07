using System.IO;
using Tyuiu.ChelolyanAE.Sprint5.Task3.V7.Lib;
namespace Tyuiu.ChelolyanAE.Sprint5.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\79829\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}