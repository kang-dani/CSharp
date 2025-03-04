using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_Quest2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                int result = int.Parse(input);
                Console.WriteLine(result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("올바른 숫자를 입력하세요!");
            }
        }
    }
}
