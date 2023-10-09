using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03HM
{
    internal class Task07
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 3, 3, 4, 5, 5 };
            var duplicates = numbers.GroupBy(x => x).Where(g => g.Count() == 2).SelectMany(g => g);
            numbers = numbers.Where(x => !duplicates.Contains(x)).ToArray();

        }
    }
}
