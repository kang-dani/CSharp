using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_3
{
	//property
	class Person
	{
		private string name;    //내부 변수
		private int age;
		public string Name
		{
			get { return name; }    //getter
			set { name = value; }   //setter
		}
		public int Age { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person();
			p.Name = "멋사4";
			p.Age = 4;
			Console.WriteLine($"이름 : {p.Name}, 나이 : {p.Age}");
		}
	}
}
