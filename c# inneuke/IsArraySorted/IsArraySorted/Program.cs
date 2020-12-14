using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsArraySorted
{  
    class Program
    {

        static void Main(string[] args)
        {
            var length = args.Length;
            string[] inputArr = new string[length];
            Array.Copy(args, 0, inputArr, 0, length);
            CheckSortedArray(length, inputArr);

        }

        private static void CheckSortedArray(int length, Array inputArr)
        {
            for (int i = 0; i < length; i++)
            {
                if (i == length-1) continue;
                int a = Convert.ToInt16(inputArr.GetValue(i));
                int b = Convert.ToInt16(inputArr.GetValue(i + 1));
                
                if (a > b)
                {
                    goto Fail;                    
                }
            }
            goto Success;
        Success: Console.WriteLine("Array is sorted low to high");
            return;
        Fail: Console.WriteLine("Array is not sorted low to high");
        
        }        
    }
}
