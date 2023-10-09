using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03HM
{
    internal class Task15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер трамвайного билета (6 цифр): ");
            string ticketNumberStr = Console.ReadLine();

            if (ticketNumberStr.Length == 6 && ticketNumberStr.All(char.IsDigit))
            {
                int ticketNumber = int.Parse(ticketNumberStr);
                int firstHalfSum = 0;
                int secondHalfSum = 0;

                for (int i = 0; i < 6; i++)
                {
                    int digit = ticketNumber % 10;
                    if (i < 3)
                    {
                        firstHalfSum += digit;
                    }
                    else
                    {
                        secondHalfSum += digit;
                    }
                    ticketNumber /= 10;
                }

                if (firstHalfSum == secondHalfSum)
                {
                    Console.WriteLine("Билет счастливый!");
                }
                else
                {
                    Console.WriteLine("Билет не счастливый.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный номер билета.");
            }

        }
    }
}
