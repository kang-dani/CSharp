using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_6
{
	class Program
	{
		//제네릭
		//<T> 제네릭 클래스를 사용하면 특정 타입에 종속되지 않는 범용 클래스를 만들 수 있음
		class Cup<T>
		{
			public T Content { get; set; }
		}
		static void Main(string[] args)
		{
			Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
			Cup<int> cupOfInt = new Cup<int> { Content = 42 };

			Console.WriteLine($"CupofString : {cupOfString.Content}");
			Console.WriteLine($"cupOfInt : {cupOfInt.Content}");

			List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
			names.Add("Dave");

			foreach (var name in names)
			{
				Console.WriteLine(name);
			}

			ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };
			IEnumerator enumerator = list.GetEnumerator();		//열거자 가져오기

			while(enumerator.MoveNext())
			{
				Console.WriteLine(enumerator.Current);
			}
		}
	}
}
