using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ordlek
{
    public static class Program
    {

        public static readonly int minimumWordLength = 7;
        public static readonly int maximumWordLength = 10;
        
        public static readonly int minimumCharMatch = 3;
        public static readonly int maximumCharMatch = 3;

        public enum longWord { minimumWordLength, maximumWordLength };
        public enum longChar { minimumCharMatch, maximumCharMatch };

        public static MinMax longestWord = new MinMax(7, 10);
        public static MinMax shortWord = new MinMax(3, 5);

        public static readonly char[] unallowedCharacters = { '-', ' ', ':', ',', '.', '\t', };

        
        public static void Main(string[] args)
        {

            bool hei = int.TryParse("5", out int x);
            string[] text = File.ReadAllLines("ordliste.txt");
            //purgeList(text, 7, 10)
            //purgeList(text, 3, 5)
            string word1 = WordMatching.GetWordAndMatch(text.MakeAUniqueListOf(longestWord), text.MakeAUniqueListOf(shortWord));
            Console.WriteLine(word1);

            // from text get two words, where last part of first word matches first part of second word
            // print them with some text

            //

        }

        //static string chosenWord()
    }

    public class MinMax
    {
        public int min, max;
        public MinMax(int min, int max)
        {
            this.min = min;
            this.max = max;
        }
    }
}
