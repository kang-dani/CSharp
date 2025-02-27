using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_4
{
	class Program
	{
		//C# 화살표 함수
		//C#에서 화살표 함수 => 람다 표현식이라고도 하며 간결한 방식으로 함수 정의 가능
		static int AddArrow(int a, int b) => a + b;
		static void PrintMessage() => Console.WriteLine("안녕하세요!");
		static void Main(string[] args)
		{
			Console.WriteLine("화살표 함수 ------------------------------------");

			Console.WriteLine(AddArrow(3, 5));
			PrintMessage();
		}
	}
}
