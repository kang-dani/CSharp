using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] names = { "Charlie", "Alice", "Bob" };
			var sortedNames = names.OrderBy(n => n);

			foreach (var name in sortedNames)
			{
				Console.WriteLine(name);
			}

			var firstName = names.First(n => n.StartsWith("A"));
			Console.WriteLine($"first Name starting with a : {firstName}");

			//메서드 구문, 쿼리구문
			int[] nums = { 5, 3, 8, 1 };

			var sortedMethod = nums.OrderBy(n => n);

			var sortedQuery = from n in nums
							  orderby n
							  select n;

			Console.WriteLine("Method syntax : ");
			foreach (var n in sortedMethod) Console.WriteLine(n);
			Console.WriteLine("Query syntax : ");
			foreach (var n in sortedQuery) Console.WriteLine(n);

			string[] words = { "apple", "banana", "cherry" };

			//Select()로 길이 추출
			var lengths = words.Select(w => w.Length);

			foreach (var length in lengths)
				Console.WriteLine(length);

			var upperWords = words.Select(w => w.ToUpper());

			foreach (var word in upperWords) Console.WriteLine(word);

			//sum 알고리즘
			int[] data = { 1, 2, 3, 4, 5 };
			int sum = 0;

			foreach (var d in data) sum += d;
			Console.WriteLine($"SUM : {sum}");

			//count
			int count = data.Length;
			Console.WriteLine($"Count : {count}");

			double avg = data.Average();
			Console.WriteLine($"AVG : {avg}");

			int max = data.Max();
			Console.WriteLine($"MAX : {max}");

			int min = data.Min();
			Console.WriteLine($"Min : {min}");

			//근삿값 구하기: NEAR 알고리즘

			//배열에서 특정 값에 가장 가까운 값을 찾는 예제

			int[] data1 = { 10, 12, 20, 25, 30 };
			int target = 22;
			int nearest = data1[0];

			foreach (var d in data1)
			{
				if (Math.Abs(d - target) < Math.Abs(nearest - target))
					nearest = d;
			}


			Console.WriteLine($"Nearest to {target}: {nearest}");

		}

	}
}
