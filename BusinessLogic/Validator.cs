using System;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public static class Validator
    {
        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            Regex ssnPattern = new Regex(@"([0-9]{9})|([0-9]{3}-[0-9]{2}-[0-9]{4})$");
            if(ssnPattern.IsMatch(ssn) && (ssn.Length == 9 || ssn.Length == 11))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            if(numToTest >= minValue && numToTest <= maxValue)
            {
                return true;
            }

            return false;
        }
    }
}
