using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03HM
{
    internal class Task13
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 7}
};

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool hasDuplicate = false;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int k = i + 1; k < matrix.GetLength(0); k++)
                    {
                        if (matrix[i, j] == matrix[k, j])
                        {
                            hasDuplicate = true;
                            break;
                        }
                    }
                    if (hasDuplicate) break;
                }
                if (hasDuplicate)
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
