using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppercaseLetterCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error: Input cannot be empty.");
                return;
            }
            int uppercaseCount = 0;
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    uppercaseCount++;
                }
            }
            Console.WriteLine($"Total uppercase letters: {uppercaseCount}");
        }
    }
}
