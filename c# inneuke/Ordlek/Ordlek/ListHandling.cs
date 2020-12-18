using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ordlek
{
    public static class ListHandling
    {



        public static string[] MakeAUniqueListOf(this string[] text, MinMax spread)
        {
            string[] UniqueList = new String[text.Length];

            for (var i = 0; i < text.Length; i++) UniqueList[i] = CompareWordsOnLinesIn(text, i);

            UniqueList = CleanAndFilter(UniqueList, spread.min, spread.max).ToArray();

            return UniqueList;
        }

        public static IEnumerable<string> CleanAndFilter(string[] theUncleanOne, int minimumLength, int maximumLength)
        {


            return theUncleanOne.Where(x => !string.IsNullOrEmpty(x) && x.Length >= minimumLength && x.Length <= maximumLength);
        }



        private static string CompareWordsOnLinesIn(string[] text, int index)
        {
            string firstInstanceOf = index == 0 ? null : text[index - 1].GetWordInLineAt(1);
            string wordAtThisLine = text[index].GetWordInLineAt(1);

            return wordAtThisLine == firstInstanceOf ? String.Empty : wordAtThisLine;
        }


        private static string GetWordInLineAt(this string line, int index)
        {
            // Oneliner with IndexOf // string gettingFirstWordFromLine = line.Substring(line.IndexOf('\t') + index, line.IndexOf('\t', line.IndexOf('\t') + index) - line.IndexOf('\t'));

            var currentWord = line.Split('\t')[index];

            return currentWord.IndexOfAny(Program.unallowedCharacters) == -1 ? currentWord : String.Empty;
        }
    }
}