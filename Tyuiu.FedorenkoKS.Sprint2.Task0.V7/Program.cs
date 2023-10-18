using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FedorenkoKS.Sprint2.Task0.V7.Lib; 

namespace Tyuiu.FedorenkoKS.Sprint2.Task0.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Федоренко К.С. | ИСПб-23-1";
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                     *");
            Console.WriteLine("* Тема: Операции сравнения                                                                      *");
            Console.WriteLine("* Задание #0                                                                                    *");
            Console.WriteLine("* Вариант #7                                                                                    *");
            Console.WriteLine("* Выполнила: Федоренко Кирилл Сергеевич    | ИСПб-23-1                                          *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=),                              *");
            Console.WriteLine("* которая вернет логическую последовательность(массив): (True, False, True, True, True, False)  *");

            int x = 103;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);


            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
            Console.WriteLine("*************************************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
            Console.WriteLine("*************************************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}