using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day07_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello, my Phone Number is 010-1234-5678.";
            string pattern = @"\d{3}-\d{4}-\d{4}";      //전화번호 패턴

            bool isMatch = Regex.IsMatch(input, pattern);
            Console.WriteLine($"전화번호가 존재하는가? {isMatch}");

        }
    }
}
