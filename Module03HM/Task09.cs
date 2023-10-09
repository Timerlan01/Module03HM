using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03HM
{
    internal class Task09
    {
        static void Main(string[] args)
        {
            string input = "This is a test string with some words containing 't'.";
            string[] words = input.Split(' ');
            string lastWord = words.Last();
            string result = string.Join(" ", words.Where(word => !word.Intersect(lastWord).Any()));
            Console.WriteLine(result);

        }
    }
}
