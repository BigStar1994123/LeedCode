﻿using System;

namespace Leetcode5_Longest_Palindromic_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var s = new Solution();
            Console.WriteLine(s.LongestPalindrome(""));

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }
        }
    }
}