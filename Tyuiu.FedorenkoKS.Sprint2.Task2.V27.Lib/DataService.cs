using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FedorenkoKS.Sprint2.Task2.V27.Lib
{
    public class DataService : ISprint2Task2V27
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool[,] result = new bool[16, 16];
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    result[i, j] = false;
                }
            }
            for (int i = 3; i <= 5; i++)
            {
                for (int j = 3; j <= 5; j++)
                {
                    result[i, j] = true;
                }
            }
            for (int i = 5; i <= 8; i++)
            {
                for (int j = 6; j <= 9; j++)
                {
                    result[i, j] = true;
                }
            }
            for (int i = 8; i <= 12; i++)
            {
                for (int j = 9; j <= 12; j++)
                {
                    result[i, j] = true;
                }
            }
            result[6, 3] = true; result[3, 9] = true; result[4, 9] = true; result[6, 13] = true; result[7, 13] = true; result[8, 13] = true;
            result[9, 6] = true; result[10, 6] = true; result[11, 6] = true; result[11, 3] = true; result[11, 4] = true; result[11, 5] = true;
            result[13, 10] = true; result[13, 11] = true; result[13, 12] = true;
            return result[y, x];
        }
    }
}