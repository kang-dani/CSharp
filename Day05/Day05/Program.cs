using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
	class Program
	{
		//전역 변수
		static int num2 = 42;

		//1. 매개변수/반환값이 없는 함수
		static void PrintHello()
		{
			Console.WriteLine("안녕하세요");
		}

		//2. 매개변수만 있는 함수
		static void PrintMessage(string message)
		{
			Console.WriteLine(message);
		}

		//3. 반환 값만 있는 함수
		static int GetNumber()
		{
			num2 = 30;
			return 42;
		}

		//4. 매개변수/반환 값이 있는 함수
		static int Add(int a, int b)
		{
			return a + b;
		}

		//5. 기본 값을 가진 매개변수 (디폴트 매개변수)
		static void Greet(string name = "손님")
		{
			Console.WriteLine($"안녕하세요, {name}");
		}

		//6. 함수 오버로딩(Overloading)
		/// <summary>
		/// 두 수를 곱하는 함수
		/// </summary>
		/// <param name="a">int, double overloading</param>
		/// <param name="b">int, double overloading</param>
		/// <returns></returns>
		static int Multiply(int a, int b)
		{
			return a * b;
		}

		static double Multiply(double a, double b)
		{
			return a * b;
		}

		static void Main(string[] args)
		{
			Console.WriteLine("함수 1 ---------------------------------");
			PrintHello();                            //1
			Console.WriteLine();

			Console.WriteLine("함수 2 ---------------------------------");
			PrintMessage("반갑습니다.");              //2
			Console.WriteLine();

			Console.WriteLine("함수 3 ---------------------------------");
			int num = GetNumber();                  //3
			Console.WriteLine(num);
			Console.WriteLine(num2);                //전역변수
			Console.WriteLine();

			Console.WriteLine("함수 4 ---------------------------------");
			int result = Add(2, 5);                 //4
			Console.WriteLine(result);
			Console.WriteLine();

			Console.WriteLine("함수 5 ---------------------------------");
			Greet();                                //5
			Greet("멋사");                           //5
			Console.WriteLine();

			Console.WriteLine("함수 6 ---------------------------------");
			Console.WriteLine(Multiply(4, 6));      //6
			Console.WriteLine(Multiply(2.3, 3.2));  //6
			Console.WriteLine();
		}
	}
}
