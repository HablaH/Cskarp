using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hvaGjørKoden1
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            int sumOfChars = 0;
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {                
                text = Console.ReadLine();
                foreach (var character in text.ToLower() ?? string.Empty)
                {
                    Console.WriteLine((int)character);
                    counts[(int)character]++;
                    sumOfChars++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {                       
                        var character = (char)i;
                        var percentage = 100 * (double)counts[i] / sumOfChars;
                        string output = character + " - " + counts[i] +" of " + sumOfChars +"  "+ percentage +"%";
                        Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                        Console.WriteLine(output);
                    }
                }                
            }
        }
    }
}
