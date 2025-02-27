using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_7
{
	class Program
	{
		//C# 구조체
		//클래스와 비슷하지만, 값 타입 (value Type)이며 가볍고 빠름
		//주로 간단한 데이터 묶음을 만들 때 사용
		//struct Point
		//{
		//	//public 어디서든 사용 가능 하게 권한 주기
		//	//private 함수 내부에서만 사용 가능 권한
		//	public int x;
		//	public int y;

		//	//생성자 정의 : 처음 생성할 때 동작하는 함수
		//	public Point(int X, int Y)
		//	{
		//		x = X;
		//		y = Y;
		//	}
		//	public void Print()
		//	{
		//		Console.WriteLine($"좌표 : {x}, {y}");
		//	}

		//}

		struct Rectangle
		{
			public int Width;
			public int Height;

			public int GetArea() => Width * Height;
		}

		static void Main(string[] args)
		{
			//Point p;        //구조체 선언 (초기화 필요)
			//Point p1 = new Point(4, 10);

			//p.x = 10;
			//p.y = 20;

			//p.Print();
			//p1.Print();

			//  var rect = new Rectangle { Width = 5, Height = 4 };
			Rectangle rect;
			rect.Width = 10;
			rect.Height = 20;
			Console.WriteLine($"Area : {rect.GetArea()}");

		}
	}
}
