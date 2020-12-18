using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Ordlek
{
    public static class WordMatching
    {

        public static string CutPart(string word, int point)
        {
            switch (point)
            {
                case 1:
                    return word.Substring(word.Length - 3);
                case 2:
                    return word.Substring(0, 3);
                default:
                    Console.WriteLine("something broke");
                    return null;
            }
        }

        public static bool DictionaryCheck(string chosenWord, string[] dictionary, int point)
        {
            string part = CutPart(chosenWord, point);
            Console.WriteLine("part to search for: " + part);
            if (part == null) return false;

            foreach (var word in dictionary)
            {
                if (part.Contains(word))
                {
                    Console.WriteLine("matched with part: " + word);
                    return true;
                }
                else continue;
            }
            return false;
        }

        public static string GetWordAndMatch(string[] words, string[] dictionary)
        {
            Random rnd = new Random();
            string[] listHuan = words;
        //here:
        //    string chosenWord = listHuan[rnd.Next(0, listHuan.Length - 1)];
        //    if (DictionaryCheck(chosenWord, dictionary, 1)) return chosenWord;
        //    else goto here;
            string chosenWord;
            do chosenWord = listHuan[rnd.Next(0, listHuan.Length - 1)];
            while (DictionaryCheck(chosenWord, dictionary, 1));

            return chosenWord;
        }
    }
}