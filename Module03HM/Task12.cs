using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03HM
{
    internal class Task12
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[j, j] % 2 == 0)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

        }
    }
}
