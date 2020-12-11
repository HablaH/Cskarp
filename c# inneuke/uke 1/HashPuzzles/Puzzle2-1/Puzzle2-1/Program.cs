using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write('#');
            //Console.Write(' ');
            //Console.WriteLine();

            int width = 8;
            int height = 4;

            for (int x = 0; x < height; x++)
            {
                for (int s1 = 0; s1 < x; s1++)
                {
                    Console.Write(' ');
                }
                for (int h = 0; h<width - (2*x); h++)
                {
                    Console.Write('#');
                }
                for (int s2 = 0; s2 < x; s2++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
