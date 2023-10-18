using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FedorenkoKS.Sprint2.Task4.V26.Lib;

namespace Tyuiu.FedorenkoKS.Sprint2.Task4.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 / Выполнил: Федоренко К. С. | ИСПб-23-1";

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* Спринт #2                                                          *");
            Console.WriteLine("* Тема:  Тернарный оператор                                          *");
            Console.WriteLine("* Задание #4                                                         *");
            Console.WriteLine("* Вариант #26                                                        *");
            Console.WriteLine("* Выполнил: Федоренко Кирилл Сергеевич | ИСПб-23-1                   *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                           *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение c         *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит       *");
            Console.WriteLine("* значение X и Y с клавиатуры. Ответ округлить до 3 знаков после     *");
            Console.WriteLine("* запятой;                                                           *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: x - 2 < y / 2, то z = (10 + (2 / x^2)             *");
            Console.WriteLine("* иначе x^2 - (1 / y)                                                *");
            Console.WriteLine("**********************************************************************");

            Console.WriteLine("Введите значение переменной X:                                       *");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y:                                       *");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                          *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}