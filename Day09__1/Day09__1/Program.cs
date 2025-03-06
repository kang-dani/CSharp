using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09__1
{
	//C#의 인터페이스란?
	interface IAnimal
	{
		void MakeSound();
	}

	class Dog : IAnimal
	{
		public void MakeSound()
		{
			Console.WriteLine("멍멍");
		}
	}

	class Cat : IAnimal
	{
		public void MakeSound()
		{
			Console.WriteLine("야옹");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			IAnimal dog = new Dog();
			IAnimal cat = new Cat();

			dog.MakeSound();
			cat.MakeSound();
		}
	}
}
