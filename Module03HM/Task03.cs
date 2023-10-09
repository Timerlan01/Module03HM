using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03HM
{
    internal class Task03
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int maxEvenIndex = Array.IndexOf(numbers, numbers.Where(x => x % 2 == 0).Max());
            Console.WriteLine("Индекс максимального четного значения: " + maxEvenIndex);

        }
    }
}
