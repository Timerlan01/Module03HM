using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03HM
{
    internal class Task02
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int maxIndex = Array.IndexOf(numbers, numbers.Max());
            Console.WriteLine("Индекс максимального значения: " + maxIndex);

        }
    }
}
