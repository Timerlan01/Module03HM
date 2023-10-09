using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03HM
{
    internal class Task08
    {
        static void Main(string[] args)
        {
            string input = "This is a test string with some words containing 'a'.";
            string[] words = input.Split(' ');
            string result = string.Join(" ", words.Where(word => !word.Contains('a')));
            Console.WriteLine(result);

        }
    }
}
