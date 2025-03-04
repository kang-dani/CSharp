using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_2
{
	class Program
	{
		//클래스 시그니처 기본구성
		//C#에서 클래스 시그니처는 클래스의 선언부를 의미한다.
		//[접근 지정자] [수정자] class 클래스 이름 : 부모 클래스, 인터페이스
		//public        abstract                :BaseClass, IComparable
		//private       sealed
		//protected     static
		//              partial

		public class Player
		{
			public string Name { get; set; }
			public int Score { get; set; }
		}

		public class Warrior : Player               //상속 받는 클래스
		{
			public int Strength { get; set; }
		}

		//public class Enemy : IAttackable, IMovable	//인터페이스를 상속받는 클래스
		//{
		//	public void Attack() { }
		//	public void Move() { }
		//}

		public abstract class Animal                    //추상 클래스
		{
			public abstract void MakeSound();
		}
		static void Main(string[] args)
		{

		}
	}
}
