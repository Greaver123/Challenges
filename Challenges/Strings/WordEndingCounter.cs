using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Strings
{
    /// <summary>
    /// program that receives a string, the program then counts the number of words ending in 'y' or 'z'.
    /// </summary>
    public class WordEndingCounter
    {
        public int CountWordsWithEnding(string text, string endingLetters)
        {
            string[] words = text.Split(',', '.', ' ');
            int count = 0;

            if (text.Count() != 0)
            {

                foreach (var word in words)
                {
                    if (word == string.Empty)
                    {
                        continue;
                    }
                    else if (endingLetters.Contains(word.Last()))
                    {
                        count++;
                    }
                }

            }
            return count;

        }
    }
}
