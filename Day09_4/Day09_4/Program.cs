using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_5
{
	class Program
	{
		abstract class Animal
		{
			//추상 메서드
			public abstract void MakeSound();

			//일반 메서드
			public void Sleep()
			{
				Console.WriteLine("동물이 잠을 잡니다.");
			}
		}

		class Dog : Animal
		{
			public override void MakeSound()
			{
				Console.WriteLine("멍멍!");
			}
		}

		class Cat : Animal
		{
			public override void MakeSound()
			{
				Console.WriteLine("야옹!");
			}
		}


		static void Main(string[] args)
		{
			Animal myDog = new Dog();
			Animal myCat = new Cat();

			myDog.MakeSound();
			myDog.Sleep();
			myCat.MakeSound();
			myCat.Sleep();
		}
	}
}
