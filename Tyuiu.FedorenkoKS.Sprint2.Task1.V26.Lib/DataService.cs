﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FedorenkoKS.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c > d);
            res[1] = (a + 17 == b) & (c > d * 6);
            res[2] = (a > b) || (c > d);
            res[3] = (a + 17 == b) && (c < d * 6);
            res[4] = !(!res[0]);
            res[5] = (a == b) ^ (c < d);
            return res;
        }
    }
}