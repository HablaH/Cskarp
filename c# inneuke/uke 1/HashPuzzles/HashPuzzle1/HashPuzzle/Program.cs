using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashPuzzles
{
    class Program
    {
        static readonly char hash = '#';
        static readonly char end = '\n';
        static readonly int width = 5;
        static readonly int height = 5;

        static void Main(string[] args)
        {
            Console.WriteLine(Looper(width, height));
        }
        
        static string Looper(int widthIn, int heightIn)
        {
            string hashOut = "";
            int height = heightIn;
            int width = widthIn;

            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    hashOut += hash;
                }
                hashOut += end;
                width--;
            }
            return hashOut;
        }
        
     
    }
}