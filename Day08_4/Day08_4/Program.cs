using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_4
{
	class Animal
	{
		public void Speak()
		{
			Console.WriteLine("동물이 소리를 냅니다.");
		}
	}
	class Dog : Animal
	{
		public void Bark()
		{
			Console.WriteLine("멍멍!");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Dog myDog = new Dog();
			Animal myAnimal = myDog;    //업캐스팅 (Dog -> Animal)
			myAnimal.Speak();           //사용 가능
										//myAnimal.Bark();            //사용 불가능
			Dog DownDog = (Dog)myAnimal;//다운 캐스팅 (명시적 변환)
			DownDog.Bark();

			//Animal myAnimal2 = new Animal();
			//Dog myDog = (Dog)myAnimal2();

			if (myDog != null)
			{
				myDog.Bark();
			}
			else
			{
				Console.WriteLine("변환 실패");
			}

			if (myAnimal is Dog myDog1)
			{
				myDog1.Bark();
			}
			else
			{
				Console.WriteLine("변환할 수 없습니다");
			}
		}
	}
}
