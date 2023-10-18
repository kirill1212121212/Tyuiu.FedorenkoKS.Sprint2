using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FedorenkoKS.Sprint2.Task3.V26.Lib
{
    public class DataService : ISprint2Task3V26
    {
        public double Calculate(double x)
        {
            if (x > 0) return Math.Round(x + Math.Pow(((x + 1) / Math.Cos(Math.Pow(x, 2))), x), 3);
            else if (x == 0) return Math.Round(x / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2))), 3);
            else if (x > -30) return Math.Round(Math.Pow(Math.Sin(Math.Pow(x, 3)) / (x + 5), x), 3);
            else return Math.Round(x + 7 * x - 1 / x, 3);
        }
    }
}