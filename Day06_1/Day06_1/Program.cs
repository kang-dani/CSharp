using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Day06_1
{
	//마린 클래스를 만드세요.
	//이름, 미네랄
	//기본 생성자, 인자있는 생성자
	class Marin
	{
		public string name;
		public int mineral;
		public Marin()
		{
			name = "마린";
			mineral = 50;
		}
		public Marin(string name, int num)
		{
			this.name = name;
			this.mineral = num;
		}
		public void ShowInfo()
		{
			Console.WriteLine($"이름 : {name}, 미네랄 : {mineral}");
		}
	}

	class SCV
	{
		public string name;
		public int mineral;
		public SCV()
		{
			name = "미네랄";
			mineral = 50;
		}
		public SCV(string name, int mineral)
		{
			this.name = name;
			this.mineral = mineral;
		}
		public void ShowInfo()
		{
			Console.WriteLine($"이름 : {name}, 미네랄 : {mineral}");
		}
	}
	//배럭 클래스를 만드세요
	//Barrack 150
	class Barrack
	{
		public string name;
		public int mineral;
		public Barrack()
		{
			name = "배럭";
			mineral = 150;
		}
		public Barrack(string name, int mineral)
		{
			this.name = name;
			this.mineral = mineral;
		}
		public void ShowInfo()
		{
			Console.WriteLine($"이름 : {name}, 미네랄 : {mineral}");
		}
	}

	//미네랄 클래스를 만드세요
	//Mineral 1500 기본으로 주세요
	//7개가 시작부터 있습니다.
	class Mineral
	{
		public int startMineral;

		public Mineral()
		{
			startMineral = 1500;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"현재 미네랄 개수 : {startMineral}");
		}
	}

	//Game Class
	class Game
	{
		public static int mineral;
		public static int gas;
		public static int charCount;
		public static void ShowInfo()
		{
			Console.WriteLine($"미네랄 {mineral} 가스 {gas} 인구수 {charCount}");
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			Game.mineral = 50;
			Game.gas = 0;
			Game.charCount = 4;
			Game.ShowInfo();

			Marin marin = new Marin();
			Marin marin1 = new Marin("불꽃테란", 300);
			SCV scv = new SCV();
			SCV scv1 = new SCV("열받은 SCV", 70);
			Barrack barrack = new Barrack();
			Barrack barrack1 = new Barrack("화끈한 배럭", 20);

			//클래스의 배열 7개 생성
			Mineral[] mineral = new Mineral[7];
			//각 배열에 인스턴스 할당
			for (int i = 0; i < mineral.Length; i++)
			{
				mineral[i] = new Mineral();
				mineral[i].ShowInfo();
			}

			marin.ShowInfo();
			scv.ShowInfo();
			barrack.ShowInfo();
			Console.WriteLine("------------------------");
			marin1.ShowInfo();
			scv1.ShowInfo();
			barrack1.ShowInfo();
		}
	}
}
