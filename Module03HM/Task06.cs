using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03HM
{
    internal class Task06
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int> { 1, 2, 4, 5 };
            int valueToInsert = 3; // Значение для вставки
            int indexToInsert = 2; // Индекс, куда вставить элемент
            numbersList.Insert(indexToInsert, valueToInsert);
            int[] numbers = numbersList.ToArray();

        }
    }
}
