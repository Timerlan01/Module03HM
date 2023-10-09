using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03HM
{
    internal class Task04
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int indexToDelete = 2; // Индекс элемента для удаления
            numbers = numbers.Where((x, i) => i != indexToDelete).ToArray();

        }
    }
}
