using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace
//클래스, 함수, 변수 이름이 충돌하는 것을 방지하기 위해 사용함

namespace dev1
{
	class MyClass
	{
		public static void SayHello()
		{
			Console.WriteLine("안녕하세요 !dev1 namespace의 MyClass입니다!");
		}
	}
}

namespace Day05_3
{
	class Program
	{
		static void SayHello()
		{
			Console.WriteLine("Day05_3에 있는 SayHello 지롱");
		}
		static void Main(string[] args)
		{
			dev1.MyClass.SayHello();
			SayHello();
		}
	}
}
