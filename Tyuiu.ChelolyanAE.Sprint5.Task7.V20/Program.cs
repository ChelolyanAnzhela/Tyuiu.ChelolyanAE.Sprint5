using Tyuiu.ChelolyanAE.Sprint5.Task7.V20.Lib;
namespace Tyuiu.ChelolyanAE.Sprint5.Task7.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 |Выполнила: Челольян А. Е. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Челольян Анжела Евгеньевна | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая заменяет все удвоенные буквы сс на с         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V20.txt";
            string Savepath = "";
            Console.WriteLine($"Данные находятся в файле {path}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Savepath = ds.LoadDataAndSave(path);
            Console.WriteLine($"Файл создан{Savepath}");
            Console.ReadKey();
        }
    }
}
