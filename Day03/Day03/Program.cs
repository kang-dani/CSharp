using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
			/*            //switch문
						int day = 9;

						switch(day)
						{
							case 1:
								Console.WriteLine("월요일");
								break;                
							case 2:
								Console.WriteLine("화요일");
								break;                
							case 3:
								Console.WriteLine("수요일");
								break;                
							case 4:
								Console.WriteLine("목요일");
								break;                
							case 5:
								Console.WriteLine("금요일");
								break;
							default:
								Console.WriteLine("오늘은 주말입니다.");
									break;
						}*/

			//캐릭터를 선택하세요. (1. 검사 2. 마법사 3. 도적)
			//switch 문으로 작성하기

			/*int character = 0;
			int attack = 0;
			int defence = 0;

			Console.Write("캐릭터를 선택하여 숫자만 입력하세요 (1.검사 2.마법사 3.도적) : ");
			character = int.Parse(Console.ReadLine());
			Console.WriteLine("========================================");*/

			/*			switch(character)
						{
							case 1:
								attack = 100;
								defence = 90;
								Console.WriteLine("검사를 선택하셨습니다. ");
								Console.WriteLine("공격력 : " + attack);
								Console.WriteLine("공격력 : " + defence);
								break;				
							case 2:
								attack = 110;
								defence = 80;
								Console.WriteLine("마법사를 선택하셨습니다. ");
								Console.WriteLine("공격력 : " + attack);
								Console.WriteLine("공격력 : " + defence);
								break;				
							case 3:
								attack = 115;
								defence = 70;
								Console.WriteLine("검사를 선택하셨습니다. ");
								Console.WriteLine("공격력 : " + attack);
								Console.WriteLine("공격력 : " + defence);
								break;

							default:
								Console.WriteLine("1~3 이외의 숫자를 선택하셨습니다. ");
								break;
						}	*/
			/*
						for (int i = 0; i < 5; i++)
						{
							Console.WriteLine("현재 값: " + i);
						}*/

			/*			//무한반복
						for (; ; )
						{
							Console.WriteLine("중요한건 꺽이지 않는 마음");
						}*/

			/*			for(int i = 0; i < 10; i++)
						{
							Console.WriteLine(i);
						}*/


			/*//1부터 10까지의 합 구하기
			int sum = 0;
			for(int i = 0; i < 10; i++)
			{
				sum += i + 1;
			}
			Console.WriteLine(sum);*/

			/*int count = 1; //초기화

			while (count <= 5) //조건식
			{
				Console.WriteLine("Count : " + count);

				count++; //증가,감소

				if (count == 3)
				{
					Console.WriteLine("3일때 반복문 탈출");
					break;
				}

			}

			Console.WriteLine("Count : " + count);*/

			/*			Random rand = new Random();				//랜덤 객체 생성

						for(int i = 0; i < 10; i++)
						{
							//0이상 10 미만의 랜덤 정수 생성
							int randNumber = rand.Next(0, 10);      //0~9
							Console.WriteLine("0 이상 10 미만의 랜덤 정수 " + randNumber);
						}
			*/
			/*			Random rand = new Random();             //랜덤 객체 생성
						int randomInRange = 0;
						for (int i = 0; i < 10; i++)
						{
							randomInRange = rand.Next(5, 15);
							Console.WriteLine("5부터 14까지 : "+ randomInRange);
						}*/

			//대장장이 키우기
			//도끼 등급 SSS 10%, SS 40%, S 50%

			/*			Random rand = new Random();
						int randomPercent = 0;

						for(int i = 0; i < 20; i++)
						{
							randomPercent = rand.Next(1, 101);

							if(randomPercent >= 1 && randomPercent <= 10)
							{
								Console.WriteLine("도끼 등급 SSS");
							}
							else if(randomPercent >= 11 && randomPercent <= 40)
							{
								Console.WriteLine("도끼 등급 SS");
							}
							else
							{
								Console.WriteLine("도끼 등급 S");
							}

							Thread.Sleep(500);		//0.5초
						}*/
			/*
						int x = 5;

						do
						{
							Console.WriteLine("최소 한 번은 실행됩니다.");
							x--;
						} while (x > 0);*/

			//continue
			//현재 반복을 건너 뛰고 다음 반복으로 넘어간다.

			/*		for(int i = 0; i <= 10; i++)
					{
						if(i % 2 == 0)
						{
							continue;
						}

						Console.WriteLine(i);		//홀수만 출력
					}*/
/*			int i = 0;

		start: // 레이블 정의
			if (i <= 5)
			{
				Console.WriteLine("현재 값: " + i);
				i++; // i를 1씩 증가시킴
				goto start; // start 레이블로 점프
			}*/
		}
	}
}
