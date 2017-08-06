using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problems
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    class Problem4_LargestPalindromeProduct
    {
        public static int GetResult()
        {
            int largestNumber = 999;
            int largestPalindrome = 0;
            for(int i = largestNumber; i >= 0; i--)
            {
                for(int j = largestNumber; j >= 0; j--)
                {
                    int number = i * j;
                    if (IsPalindrome(number))
                    {
                        if (number > largestPalindrome)
                            largestPalindrome = number;
                    }
                }
            }
            return largestPalindrome;
        }

        private static bool IsPalindrome(int number)
        {
            string numberStr = number.ToString();
            return numberStr == ReverseString(numberStr);
        }

        private static string ReverseString(string text)
        {
            var stringBuilder = new StringBuilder();
            for(int i = text.Length-1; i >= 0; i--)
            {
                stringBuilder.Append(text[i]);
            }
            return stringBuilder.ToString();
        }
    }
}
