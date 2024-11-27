using Tyuiu.ChelolyanAE.Sprint5.Task1.V17.Lib;
namespace Tyuiu.ChelolyanAE.Sprint5.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 |Выполнила: Челольян А. Е. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Челольян Анжела Евгеньевна | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция на диапазноне [-5;5]с шагом 1.                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int a = -5;
            int b = 5;
            Console.WriteLine($"Старт шага{a}");
            Console.WriteLine($"конец шага{b}");
            string res =ds.SaveToFileTextData(a,b);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Файл {res}");
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
