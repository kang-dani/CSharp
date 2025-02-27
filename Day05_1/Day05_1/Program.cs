using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_1
{
	class Program
	{

		//out 키워드 (여러 값을 반환할 때)
		static void Divide(int a, int b, out int quotient, out int remainder)
		{
			quotient = a / b;
			remainder = a % b;
		}

		//ref 키워드 (값을 참조하여 수정)
		static void Increase(ref int num)
		{
			num += 10;
		}

		//prams 키워드 (가변 매개변수)
		static int Sum(params int[] numbers)
		{
			int total = 0;
			foreach (int num in numbers)
			{
				total += num;
			}

			return total;
		}


		static void Main(string[] args)
		{
			Console.WriteLine("out 키워드 -----------------------------");
			int q, r;                                           //out 키워드
			Divide(10, 3, out q, out r);

			Console.WriteLine($"몫 : {q}, 나머지 : {r}");
			Console.WriteLine();

			Console.WriteLine("ref 키워드 -----------------------------");
			int value = 5;                                      //ref 키워드
			Increase(ref value);

			Console.WriteLine(value);
			Console.WriteLine();

			Console.WriteLine("params 키워드 --------------------------");
			Console.WriteLine(Sum(1, 2, 3));                    //params
			Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
			Console.WriteLine();
		}
	}
}
