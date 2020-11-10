using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            var SentenceString = Console.ReadLine();

            if(SentenceString.Trim().Length == 1)
            {
                Console.WriteLine("The unchanged string is: " + SentenceString.Trim());
            }
            else if (string.IsNullOrWhiteSpace(SentenceString))
            {
                Console.WriteLine("ERROR IN INPUT");
            }
            else
            {
                var firstchar = SentenceString.First();
                var lastchar = SentenceString.Last();
                var middlechar = SentenceString.Substring(1, (SentenceString.Length - 2));
                var NewString = $"{lastchar}{middlechar}{firstchar}";
                Console.WriteLine("The new string is: " + NewString);
            }
            Console.ReadLine();
        }
    }
}
