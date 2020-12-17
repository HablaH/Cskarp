using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ordlek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("ordliste.txt");
            //purgeList(text, 7, 10)
            //purgeList(text, 3, 5)
            string word1 = getWordAndMatch(purgeList(text, 7, 10), purgeList(text, 3, 5));
            Console.WriteLine(word1);
        }

        static string getWord(string line)
        {
            char[] check = { '-', ' ', ':', ',', '.' };
            string[] devided = line.Split('\t');
            string word = devided[1];
            if (char.IsWhiteSpace(word[0]))
                word = word.Substring(1);
            if (word.IndexOfAny(check) != -1) return "";
            return word;
        }

        static string[] purgeList(string[] text, int min , int max)
        {
            List<string> cleanList = new List<string>();
            string previousStr = null;
            foreach (string line in text)
            {
                string word = getWord(line);
                if (word != previousStr && word.Length >=min && word.Length <=max)
                {
                    cleanList.Add(word);
                    previousStr = word;
                }
                else continue;
            }
            return cleanList.ToArray();
        }

        static string getWordAndMatch(string[] words, string[] dictionary) 
        {
            Random rnd = new Random();
            string[] listHuan = words;
        here:
            string chosenWord = listHuan[rnd.Next(0, listHuan.Length - 1)];
            if (dictionaryCheck(chosenWord, dictionary, 1)) return chosenWord;
            else goto here;
            
        }

        static bool dictionaryCheck(string chosenWord, string[] dictionary, int point)
        {
            string part = cutPart(chosenWord, point);
            Console.WriteLine( "part to search for: " + part);
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

        static string cutPart(string word, int point)
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

        static string matchWord(string chosen,)
    }
}
