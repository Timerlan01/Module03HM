using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03HM
{
    internal class Task14
    {
        static void Main(string[] args)
        {
            int spaceCount = 0;
            char inputChar;
            do
            {
                inputChar = Console.ReadKey().KeyChar;
                if (inputChar == ' ')
                {
                    spaceCount++;
                }
            } while (inputChar != '.');
            Console.WriteLine("\nКоличество пробелов: " + spaceCount);

        }
    }
}
