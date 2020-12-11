using System;

namespace Puzzle2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write('#');
            //Console.Write(' ');
            //Console.WriteLine();

            int width = Convert.ToInt32(args[0]);
            int height = width;

            for (int x = 0; x < height; x++)
            {
                if (x < width / 2)
                {
                    for (int s1 = width / 2 - 1; s1 > x; s1--) Console.Write(' ');
                    for (int h = 0; h < (x + 1) * 2; h++) Console.Write('#');
                };
                if (x >= width / 2)
                {
                    for (int s1 = 0; s1 < x - width / 2; s1++) Console.Write(' ');
                    for (int h = 0; h < (width - x) * 2; h++) Console.Write('#');
                };
                Console.WriteLine();
            }
        }
    }
}
