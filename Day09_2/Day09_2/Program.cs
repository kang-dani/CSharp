using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_2
{
	class Person
	{
		public string name;
		public int age;

		public Person()
		{
			name = "UnKnown";
			age = 0;
		}
		public Person(string name)
		{
			this.name = name;
			age = 0;
		}
		public Person(string name, int age)
		{
			this.name = name;
			this.age = age;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person();
			Console.WriteLine($"이름 : {p.name}, 나이 : {p.age}");

			Person p1 = new Person("Alice");
			Console.WriteLine($"이름 : {p1.name}, 나이 : {p1.age}");

			Person p2 = new Person("멋사", 4);
			Console.WriteLine($"이름 : {p2.name}, 나이 : {p2.age}");
		}
	}
}
