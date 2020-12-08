using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassordGenerator
{
    class Program
    {
        static readonly char[] lowerCaseCharacters = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        static readonly char[] upperCaseCharacters = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        static readonly char[] symbolCharacters = {'!','"','#','¤','%','&','(',')','{','}','[',']'};
        static readonly char[] digitCharacters = {'1','2','3','4','5','6','7','8','9'};
        static readonly Random rnd = new Random();

        static void Main(string[] args)
        {         
            if (IsValid(args)) 
            { 
                Console.WriteLine(PadString(args));
                Console.WriteLine(ReRandomizeString(GetRandomLetters(PadString(args))));
            } 
            else Console.WriteLine(ShowHelpText());
            return;
        }
        static string ShowHelpText()
        {

            return ("Options:\r\n- l = lower case letter\r\n- L = upper case letter\r\n- d = digit\r\n- s = special character !" +
                (char)34 +
                @"#¤%&(){}[]" +
                "\r\nExample: PasswordGenerator 14 lLssdd" +
                "\r\n         Min. 1 lower case" +
                "\r\n         Min. 1 upper case" +
                "\r\n         Min. 2 special characters" +
                "\r\n         Min. 2 digits ");
        }

        static bool IsValid(string[] args)
        {
            if (args.Length == 2 && IsNumber(args[0]) && IsAcceptedOptions(args[1])) return true;
            else return false;
        }

        static bool IsNumber(string args) 
        {
            foreach (var n in args)
            {
                if (!char.IsDigit(n)) return false;
            }
            return true;
        }

        static bool IsAcceptedOptions(string args)
        {
            foreach (var c in args)
            {
                if ((int)c != 108 && (int)c != 76 && (int)c != 115 && (int)c != 100) return false;                
            }
            return true;
        }

        static string PadString(string[] args)
        {
            int passLength = Convert.ToInt32(args[0]);
            return args[1].PadRight(passLength, 'l');
        }

        static string GetRandomLetters (string args) 
        {
            string randomizedWord = "";
            for (int i = 0; i < args.Length; i++)
            {                
                switch (args[i])
                {
                    case 'l':
                       randomizedWord += SwitchToRandom(lowerCaseCharacters);;
                        break;
                    case 'd':
                       randomizedWord += SwitchToRandom(digitCharacters);
                        break;
                    case 's':                
                        randomizedWord += SwitchToRandom(symbolCharacters);
                        break;
                    case 'L':
                        randomizedWord += SwitchToRandom(upperCaseCharacters);
                        break;                    
                }
            }
            return randomizedWord;
        }

        static string ReRandomizeString(string args)
        {
            return new string(args.ToCharArray().OrderBy(x=>Guid.NewGuid()).ToArray());
        }
        static char SwitchToRandom (char[] args)
        {          
            int randomNumber = rnd.Next(0, args.Length);           
            return args[randomNumber];
        }
    }
}
