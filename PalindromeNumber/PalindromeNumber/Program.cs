using System;

namespace PalindromeNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 9229;

            IsPalindrome(x);
        }

        private static void IsPalindrome(int x)
        {
            int rem, quo;

            rem = x % 10;
            quo = x / 10;

            Console.WriteLine($"Reminder is {rem}");
            Console.WriteLine($"Quo is {quo}");
            
        }
    }
}
