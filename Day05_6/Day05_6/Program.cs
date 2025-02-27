﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_6
{
	class Program
	{
		//열거형이란?
		//Enumeration  enum 
		//숫자 값에 이름을 부여하는 자료형
		//가독성을 높이고, 의미 있는 값으로 표현 가능
		//기본적으로 첫 번째 값은 0부터 시작하며 1씩 증가


		//기본적인 enum 사용법
		enum DayOfWeek
		{
			Sunday,   //0
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday
		}


		//2.enum  값 변경 (0부터 시작하지않기)
		enum StatusCode
		{
			Success = 200,
			BadRequest = 400,
			Unauthorized = 401,
			NotFound = 404
		}

		//문제
		//열거형과 함수를 이용해서 풀어주세요.
		//Weapontype.Sword   검을 선택했습니다.
		//Weapontype.Bow    활을 선택했습니다.
		//Weapontype.Staff  지팡이를 선택했습니다. 

		//ChooseWeapon(WeaponType.Bow); //출력 :  활을 선택했습니다

		//enum Weapontype
		//{
		//	Sword,
		//	Bow,
		//	Staff,
		//}

		//static void ChooseWeapon(Weapontype weapontype)
		//{
		//	switch(weapontype)
		//	{
		//		case Weapontype.Sword:
		//			Console.WriteLine("검을 선택했습니다.");
		//			break;
		//		case Weapontype.Bow:
		//			Console.WriteLine("활을 선택했습니다.");
		//			break;
		//		case Weapontype.Staff:
		//			Console.WriteLine("지팡이를 선택했습니다.");
		//			break;
		//	}
		//}

		static void Main(string[] args)
		{
			DayOfWeek today = DayOfWeek.Wednesday;

			//숫자를 직접 사용하지 않고, 의미 있는 이름으로 관리 가능
			Console.WriteLine(today);
			Console.WriteLine((int)today);

			StatusCode status = StatusCode.NotFound;
			Console.WriteLine(status);
			Console.WriteLine((int)status);

			//Console.Write("무기를 선택하세요 (0.검, 1.활 2.지팡이) : ");
			//int input = int.Parse(Console.ReadLine());
			//Weapontype weapon = (Weapontype)input;
			//ChooseWeapon(weapon);
		}

	}
}