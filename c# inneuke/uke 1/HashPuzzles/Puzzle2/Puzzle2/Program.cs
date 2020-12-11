using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int col = Convert.ToInt32(args[0]);
            int row = col * 2 - 1;
            string hashOut = "";
            for (int i = 0; i <= row; i++)
            {
                if (i < col)
                {
                    for (int c = 0; c < i + 1; c++)
                    {
                        hashOut += '#';
                    }
                    hashOut += '\n';
                }
                if (i > col)
                {
                    for (int c = 0; c < row+1 - i; c++)
                    {
                        hashOut += '#';
                    }
                    hashOut += '\n';
                }
            }
            Console.WriteLine(hashOut);
        }
    }
}
