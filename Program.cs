using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.roman_to_integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int current_number;
            int previous_number = 0;
            int result = 0;
            string s = "MCM";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == 'I')
                    current_number = 1;
                else if (s[i] == 'V')
                    current_number = 5;
                else if (s[i] == 'X')
                    current_number = 10;
                else if (s[i] == 'L')
                    current_number = 50;
                else if (s[i] == 'C')
                    current_number = 100;
                else if (s[i] == 'D')
                    current_number = 500;
                else
                    current_number = 1000;

                if (current_number > previous_number)
                    result += current_number;
                else
                    result -= current_number;

                previous_number = current_number;
            }
            Console.WriteLine(result);
        }
    }
}
