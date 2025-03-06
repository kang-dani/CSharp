using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello;

namespace Hello
{
	class Say
	{
		public void SayHello() { Console.WriteLine("Hello"); }
	}
}

namespace Day09
{
	class Program
	{
		static void Main(string[] args)
		{
			Say say = new Say();
			say.SayHello();
		}
	}
}
