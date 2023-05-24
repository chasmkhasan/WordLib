using System;

namespace Palindrome.Logic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to see if its palindrome or not");
            string text = Console.ReadLine();

            Palindrome palindrome = new Palindrome();

            Console.WriteLine($"The result is {palindrome.IsPalindrome(text).ToString()}");
            Console.ReadLine();
        }
    }

}