using System;

namespace Leetcode67_Add_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var s = new Solution();
            var result = s.AddBinary("1010", "1011");
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            var j = b.Length - 1;
            var carry = false;
            var r = '0';
            for (var i = a.Length-1; i >= 0; i--)
            {
                if (carry)
                {
                    var (aa, bb) = AddChar(a[i], '1');
                }

                (r, carry) = AddChar(a[i], b[j]);
            }

        }

        private (char, bool) AddChar(char a, char b)
        {
            if (a == '1' && b == '1')
            {
                return ('0', true);
            }
            else if (a == '0' && b == '1')
            {
                return ('1', false);
            }
            else if (a == '1' && b == '0')
            {
                return ('1', false);
            }
            else
            {
                return ('0', false);
            }
        }
    }
}
