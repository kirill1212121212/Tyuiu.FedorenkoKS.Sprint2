using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FedorenkoKS.Sprint2.Task5.V2.Lib;

namespace Tyuiu.FedorenkoKS.Sprint2.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Федоренко К.С. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Федоренко Кирилл Сергеевич      | ИСПНб-23-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По данному месяцу, определите в какую пору года попадает этот месяц     *");
            Console.WriteLine("* Зима, Лето, Весна, Осень).                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int numMouth = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((numMouth < 1) || (numMouth > 12))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = "Этот меняц пренадлежит времени года: " + ds.FindMonthSeason(numMouth);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}