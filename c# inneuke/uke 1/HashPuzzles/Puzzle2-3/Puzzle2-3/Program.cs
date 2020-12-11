using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 14;
            int height = 8;

            for (int x = 0; x < height; x++)
            {
                if (x < height / 2) 
                { 
                    for (int fs = 0                     ; fs < x    ; fs++) Console.Write(" ");
                    for (int fh = 0                     ; fh < x+1  ; fh++) Console.Write("#");
                    for (int ss = width-2-(x*(height/2)); ss > 0    ; ss--) Console.Write(" ");
                    for (int sh = 0                     ; sh < x+1  ; sh++) Console.Write("#");
                }
                else
                { 
                    for (int fs = width/2-x; fs>0; fs--) Console.Write(" ");
                    for (int fh = width / 2 - x+1; fh > 0; fh--) Console.Write("#");
                    for (int ss = ((x-height/2) * (height / 2)); ss > 0; ss--) Console.Write(" ");
                    for (int sh = width / 2 - x+1; sh > 0; sh--) Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}
