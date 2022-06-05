using System;

namespace Palindrome
{
    class Program
    {
        public static Boolean isPalindrome(string str)
        {

            int i = 0;
            int j = str.Length - 1;

            while (!Char.IsLetterOrDigit(str[i])) i++;
            while (!Char.IsLetterOrDigit(str[j])) j--;

            if(i < j)
            {
                if(char.ToLower(str[i]) != char.ToLower(str[j])) return false;
                isPalindrome(str.Substring(i+1,j-1));
            }
            
            return true;
        }
        static void Main(string[] args)
        {
            string str = "Race Car!";
            string str1 = "rice";

            System.Console.WriteLine(isPalindrome(str));
            System.Console.WriteLine(isPalindrome(str1));
        }
    }
}
