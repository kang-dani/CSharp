using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day07_Quest5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("짝수만 출력합니다. ");
            foreach (var num in evenNumbers) Console.Write(num + " ");

            Console.WriteLine();

            var sum = numbers.Sum();
            Console.WriteLine("합계를 출력합니다.");
            Console.WriteLine(sum);

        }
    }
}
