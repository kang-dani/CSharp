using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_8
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> ages = new Dictionary<string, int>();

			ages["금도끼"] = 10;
			ages["은도끼"] = 5;
			ages["돌도끼"] = 1;

			foreach (var pair in ages)
			{
				Console.WriteLine($"{pair.Key} : {pair.Value}");
			}

			string str = null;

			if (str == null)
			{
				Console.WriteLine("str is null");
			}

			int? nullableInt = null;
			Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");
			nullableInt = 10;
			Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

			string str1 = null;
			Console.WriteLine(str ?? "DefaultValue");       //str이 null이면 DefaultValue가 출력

			str = "Hello";
			Console.WriteLine(str?.Length);					//str은 null이 아니므로 길이 출력
		}
	}
}
