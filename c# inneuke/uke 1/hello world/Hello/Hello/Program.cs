using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarere variabler
            bool b;
            int n;
            float f;
            double d;
            string s;

            //tilordne verdier
            b = true;
            n = 5;
            f = 3.2f;
            d = 1.2;
            s = "qwerty";

            //deklarere og tilordne
            bool b2 = false;
            int n2 = 82;
            float f2 = 5.24f;
            double d2 = 9.357;
            string s2 = "Lorem Ipsum osv.";

            var b3 = false;
            var n3 = 29;
            var f3 = 1.14f;
            var d3 = 3.14;
            var s3 = "Ibsens ripsbusker og andre buskvekster";




            if (args.Length == 0)
            {
                Console.WriteLine("Hello World! ingen parametere");
            }
            else
            {
                Console.WriteLine("Hello World! Parameters: " + args.Length);
            }

            for (var i = 0; i < args.Length; i++)
            {
                var parameterNo = i + 1;
                Console.WriteLine("Parameter " + parameterNo + ": " + args[i]);

                foreach (var text in args)
                {
                    Console.WriteLine("Parameter: " + text);
                }
            }
        }
    }
}
