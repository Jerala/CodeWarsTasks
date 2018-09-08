using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTasks.ParseInt_Reloader
{
    class Parser
    {
        public static int parseInt(String numStr)
        {

            if (numStr.Equals("zero")) return 0;
            if (numStr.Equals("one million")) return 1000000;

            String[] digits = new String[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen",
            "twenty" };
            String[] numbers = numStr.Split(new char[] { ' ' });
            String[] decades = new String[] {null, null, "twenty", "thirty",
                "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            int result = 0;
            int factor = 1;
            for (int curWord = numbers.Length - 1; curWord >= 0; curWord--)
            {
                if (numbers[curWord].Equals("hundred"))
                {
                    factor *= 100;
                    if (factor < result)
                        factor = 100000;
                }
                else if (numbers[curWord].Equals("thousand"))
                    factor *= 1000;
                else if (numbers[curWord].Contains("-"))
                {
                    result += (decades.ToList().IndexOf(numbers[curWord].Substring(0,
                            numbers[curWord].IndexOf("-"))) * 10
                            + digits.ToList().IndexOf
                            (numbers[curWord].Substring(numbers[curWord].IndexOf("-") + 1))) * factor;
                    factor = 1;

                }
                else if (numbers[curWord].Equals("and"))
                    continue;
                else
                {
                    result += digits.ToList().IndexOf(numbers[curWord]) * factor;
                    factor = 1;
                }
            }

            return result;
        }
    }
}
