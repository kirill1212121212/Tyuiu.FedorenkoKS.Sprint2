using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

// x = 103 
// y = 475
// true, false, true, true, true, false

namespace Tyuiu.FedorenkoKS.Sprint2.Task0.V7.Lib
{
    public class DataService : ISprint2Task0V7
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 372 == y;
            res[1] = x + 372 != y;
            res[2] = x < y;
            res[3] = x + 374 > y;
            res[4] = x <= y;
            res[5] = x + 3 >= y;

            return res;
        }
    }
}