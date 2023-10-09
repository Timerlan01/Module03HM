using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03HM
{
    internal class Task10
    {
        static void Main(string[] args)
        {
            string input = "This is a test string with some words like 'bob' and 'wow'.";
            string[] words = input.Split(' ');
            string result = string.Join(" ", words.Select(word =>
            {
                if (word.Length >= 2 && word[0] == word[word.Length - 1])
                {
                    return "[" + word + "]";
                }
                return word;
            }));
            Console.WriteLine(result);

        }
    }
}
