using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace EncryptStringHard
{
    class Program
    {
        static void Main(string[] args)
        {
            string location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string outputFileName = "output.txt";
            string text = (File.ReadAllText(location + args[0]));
            using (StreamWriter sw = File.CreateText(Path.Combine(location, outputFileName)))
            {
                sw.WriteLine(text.Sentence(args[1][0]));
            }
               
                Console.WriteLine(location);
            //Console.WriteLine(text.Sentence('a'));
        }
    }

    static class Encryptu
    {       
        public static string Sentence(this string text, char character) 
        {
            return EncryptWithKey(text, character);
        }

        private static string EncryptWithKey(string text, char key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] selectedCipher = ChooseArray(key);
            string encryptedString = String.Empty;
            foreach (char character in text)
            {
                if (!char.IsLetter(character))
                {
                    encryptedString += character;
                }
                else
                {

                    //int index = alphabet.ToString().IndexOf(character);
                    int index = Array.IndexOf(alphabet, character);
                    encryptedString += selectedCipher[index];
                }
            }


            return encryptedString;
        }

        private static char[] ChooseArray(char key)
        {
            switch (key)
            {
                case 'a':
                    return new char[] {'z','y','x','w','v','u','t','s','r','q','p','o','n','m','l','k','j','i','h','g','f','e','d','c','b','a'};
                default: 
                    Console.WriteLine("could not recognize key");
                    return new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

            }
        }
    }
    
    class Dicryptu
    {

    }


}
