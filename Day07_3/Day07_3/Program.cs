using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_3
{
	class Program
	{
		static void Main(string[] args)
		{
			//value type (Stack) / reference type (Heap)

			int valueType = 10;
			object referenceType = valueType;

			valueType = 20;
			Console.WriteLine($"ValueType : {valueType}");
			Console.WriteLine($"ReferenceType : {referenceType}");

			//Boxing UnBoxing
			//값 형식을 참조 형식으로 변환(박싱), 다시 값 형식으로 변환(언박싱)
			int value = 42;
			object boxed = value;
			int unboxed = (int)boxed;

			Console.WriteLine($"Boxed : {boxed}, UnBoxed : {unboxed}");

			//is 연산자 형식 비교하기
			//객체가 특정 형식인지 확인할 수 있음
			object obj = "Hello";
			Console.WriteLine(obj is string);
			Console.WriteLine(obj is int);

			//as 연산자 형식 변환하기
			//as 연산자를 사용해 안전하게 형 변환을 수행함 (null값 형태가 있는 타입을 안전하게 변환할 때)
			object obj1 = "Hello";
			string str = obj1 as string;
			Console.WriteLine(str is string);

			var obj2 = 42;
			if (obj2 is int number)
			{
				Console.WriteLine($"Number : {number}");
			}
			else
			{
				Console.WriteLine("Not a Number");
			}

			//문자열 다루기
			string greeting = "Hello";
			string name = "Alice";

			string message = greeting + ", " + name + "!";
			Console.WriteLine(message);

			Console.WriteLine($"Length of name : {name.Length}");
			Console.WriteLine($"To Upper : {name.ToUpper()}");
			Console.WriteLine($"Substring : {name.Substring(1)}");

			//string 다양한 메서드
			string text = "C# is awesome!";
			Console.WriteLine($"Containes 'awesone' : {text.Contains("awesome")}");
			Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
			Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
			Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome", "great")} ");

			StringBuilder sb = new StringBuilder("Hello");
			sb.Append(",");
			sb.Append("World");
			Console.WriteLine(sb.ToString());

			//String과 StringBuilder 클래스 성능 차이 비교
			//반복적으로 문자열을 수정할 때 stringBuilder가 효율적이다.

			int iterations = 10000;
			Stopwatch stopwatch = Stopwatch.StartNew();

			string Text = "";

			for (int i = 0; i < iterations; i++)
			{
				text += "a";
			}

			stopwatch.Stop();
			Console.WriteLine($"String : {stopwatch.ElapsedMilliseconds}ms");

			stopwatch.Restart();
			StringBuilder sb1 = new StringBuilder();

			for (int i = 0; i < iterations; i++)
			{
				sb1.Append("a");
			}
			stopwatch.Stop();
			Console.WriteLine($"StringBuilder : {stopwatch.ElapsedMilliseconds}ms");

			//예외 처리하기
			//예외는 프로그램 실행 중 발생하는 오류
			//예외를 처리하면 프로그램이 중단되지 않고 계속 실행할 수 있음
			//try-catch

			try
			{
				int[] numbers = { 1, 2, 3 };
				Console.WriteLine(numbers[5]);	//예외 발생
			}
			catch(IndexOutOfRangeException ex)
			{
				Console.WriteLine($"Error : {ex.Message}");
			}

			try
			{
				int number3 = int.Parse("Not A Number");	//오류 발생
			}
			catch(FormatException ex)
			{
				Console.WriteLine($"Format Error : {ex.Message}");
			}
			finally
			{
				Console.WriteLine("항상 실행됩니다.");
			}

			//Exception 클래스
			//모든 예외의 기본 클래스입니다.

			try
			{
				int number4 = int.Parse("Not A number");
			}
			catch(Exception e)
			{
				Console.WriteLine($"General Error : {e.Message}");
			}

			//throw 구문으로 직접 예외 발생 시키기
			try
			{
				int age = -5;
				if (age < 0)
				{
					throw new ArgumentException("Age cannot be negative");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Exception : {ex.Message}");
			}
		}
	}
}
