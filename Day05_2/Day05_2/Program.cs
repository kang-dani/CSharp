using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_2
{
    class Program
    {

        //재귀함수 (자기 자신을 호출)
        static int Factorial(int n)
        {
            if(n <= 1)
            {
                return 1;       //출력 겸 탈출
            }

            return n * Factorial(n - 1);
		}

        static void Main(string[] args)
        {
            Console.WriteLine("재귀함수 -------------------------------");
            Console.WriteLine(Factorial(5));                    //Factorial
            Console.WriteLine();


        }
    }
}
