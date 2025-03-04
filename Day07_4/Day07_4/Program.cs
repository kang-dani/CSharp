using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_4
{
	class Program
	{
		static void Main(string[] args)
		{
			//배열과 컬렉션
			int[] numbers = { 1, 2, 3, 4, 5 };
			foreach (var num in numbers)
			{
				Console.WriteLine(num);
			}

			//배열과 비슷하지만 동적으로 크기가 변하는 가변 길이 컬렉션
			List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

			names.Add("Dave");
			names.Remove("Bob");

			foreach (var name in names)
			{
				Console.WriteLine(name);
			}

			List<int> list = new List<int>();

			list.Add(1);
			list.Add(2);
			list.Add(3);

			foreach(int i in list)
			{
			    Console.WriteLine(i);
			}

			Console.WriteLine(list[1]);
			list.Insert(1, 100);
			Console.WriteLine(list[1]);

			Console.WriteLine(list[0]);

			list.Insert(1, 100);
			Console.WriteLine(list.Count);

			list[2] = 200;

			foreach (int i in list)
			{
				Console.WriteLine(i);
			}
		}
	}
}
