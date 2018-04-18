using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Miscellaneous
{

    public class NumberToStringFormatter
    {
        private string[] ones = { "one", "two", "three", "for", "five", "six", " seven", "eight", "nine", "ten",
            "eleven", "twelve", "thirteen", "forteen", "fifteen", "sixteen", "seventeen", "eighteen", "ninteen" };

        private string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };

        /// <summary>
        /// Takes input as a number and converts it into string format
        /// </summary>
        /// <param name="number"> number to convert. Must be between 1 and 99</param>
        /// <returns>converted number (example: 54 converts to fifty four </returns>
        public string FormatNumber(int number)
        {
            if (number < 20 && number > 0)
            {
                return ones[number - 1];
            }
            else if (number >= 20 && number <= 99)
            {
                if (number % 10 == 0)
                {
                    int index = (number / 10) - 2;
                    return tens[index];
                }
                else
                {
                    string onesText = ones[(number % 10) - 1];
                    string tensText = tens[(int)(number / 10) - 2];
                    return tensText + " " + onesText;
                }

            }
            else
            {
                throw new ArgumentException("Number must be between 1 and 99");
            }
        }



    }
}
