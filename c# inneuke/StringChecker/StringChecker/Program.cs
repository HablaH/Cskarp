using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringChecker
{
    class Program
    {
        static readonly string textFile = @"C:\Users\HablaH\Documents\Koding\Github\Cskarp\c# inneuke\uke 1\StringChecker\StringChecker\Bull.txt";
        static void Main(string[] args)
        
        {
            String text;
            text = new string(System.IO.File.ReadAllText(textFile).Where(x => x==' ' || char.IsLetterOrDigit(x)).ToArray());
            Console.WriteLine(text);
            string longestWord = PartitionAndCheckString(text)[0];
            string mostVowels = PartitionAndCheckString(text)[1];
            Console.WriteLine("Longest word is: " + longestWord + " " + longestWord.Length);
            Console.WriteLine("Most vowels in: " + mostVowels + ", " + mostVowels.Count(c => "aeiou".Contains(Char.ToLower(c))) + " vowels");
            Console.WriteLine("text contains " + text.AllIndexesOf(" ").Count + " words");


        }
        static string[] PartitionAndCheckString(string text)
        {
            List<int> indexes = text.AllIndexesOf(" ");
            string longestWord = "i";
            string mostVowels = "i";
            for (int i = 0; i < indexes.Count; i++)
                
            {
                int start = i == 0 ? 0 : indexes[i - 1] + 1;
                string word = text.Substring(start, indexes[i]- start);
                longestWord = LongestWord(word, longestWord);
                mostVowels = VowelCount(word, mostVowels);
            }
            string[] stats = new string[] { longestWord, mostVowels };
            return stats;
        }
        static string LongestWord(string word, string oldWord)
        {
            int wordLength = word.Length;
            int oldWordLength = oldWord.Length;
            if (wordLength > oldWordLength) return word;
            else return oldWord;
        }

        static string VowelCount(string word, string oldVowelWord)
        {
            string vowels = word.IndexOf('y') == 0 ? "aeiou" : "aeiouy";
            int oldVowelcount = oldVowelWord.Count(c => vowels.Contains(Char.ToLower(c)));
            int vowelCount = word.Count(c => vowels.Contains(Char.ToLower(c)));
            if (vowelCount > oldVowelcount) return word;
            else return oldVowelWord;
        }
      



         
    }
}
