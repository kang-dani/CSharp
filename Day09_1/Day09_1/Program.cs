using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_1
{
	class Person
	{
		private string name;         //필드 클래스의 데이터를 저장하는 멤버입니다.

		public void SetName(string n)
		{
			name = n;
		}
		public string GetName()
		{
			return name;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person();        //객체 생성 - 인스턴스
			p.SetName("다니");
			Console.WriteLine(p.GetName());

		}
	}
}
