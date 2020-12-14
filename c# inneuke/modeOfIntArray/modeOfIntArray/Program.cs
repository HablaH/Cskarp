using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeOfIntArray
{
    class Program
    {
        static void Main(string[] args)
        { 

            int[] intArgs = new int[args.Length];
            try 
            {
             intArgs = args.Select(int.Parse).ToArray();
                intArgs.GetMode();
            }
            catch
            {
                Console.WriteLine("All arguments are not integers, or value of integer exceed 999");
            }
            
        }        
    }
    static class Methods
    {
        public static void GetMode(this int[] input)
        {
            int[] count = new int[1000];
            foreach (var n in input)
            {
                count[n]++;
            }
            int modeValue = 0;
            int valueIndex = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > modeValue)
                {
                    modeValue = count[i];
                    valueIndex = i;
                }
                else continue;
            }
            Console.WriteLine($"mode of array is: {valueIndex}, it occurs {modeValue} times");
        }
    }
}
