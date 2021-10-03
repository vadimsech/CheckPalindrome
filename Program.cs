using System;

namespace CheckPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(656));
            Console.WriteLine(IsPalindrome(-767));
            Console.WriteLine(IsPalindrome(650));
            Console.WriteLine(IsPalindrome(9));
            Console.WriteLine(IsPalindrome(894));
            Console.WriteLine(IsPalindrome(1234));
        }

        static bool IsPalindrome(int ourNumber)
        {
            if (ourNumber < 0)
            {
                return false;
            }
            if (ourNumber % 10 == 0)
            {
                return false;
            }
            return ourNumber == ReverseNumber(ourNumber);
        }
        static int ReverseNumber(int numberToReverse)
        {
            int result = 0;
            int temp;
            while (numberToReverse > 9 || numberToReverse < -9)
            {
                temp = numberToReverse % 10;
                numberToReverse /= 10;
                result = result * 10 + temp;
            }
            result = result * 10 + numberToReverse;
            if (result >= int.MaxValue || result <= int.MinValue)
            {
                return 0;
            }
            return result;
        }
    }
}
