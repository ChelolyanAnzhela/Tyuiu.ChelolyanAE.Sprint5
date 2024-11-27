using Tyuiu.ChelolyanAE.Sprint5.Task0.V9.Lib;
namespace Tyuiu.ChelolyanAE.Sprint5.Task0.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds= new DataService();
            Console.Title = "Спринт #5 |Выполнила: Челольян А. Е. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Челольян Анжела Евгеньевна | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Данщ выражение вычислить его значение при х=3 , результат сохранить в   *");
            Console.WriteLine("*  файл OutPutFileTask0.txt и вывести на консоль.Округлить до трех знаков *");
            Console.WriteLine("*  после запятой                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 3;
            Console.WriteLine($"Значение переменной х = {x}");
            string path = ds.SaveToFileTextData(x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("Создан");
        }
    }
}
