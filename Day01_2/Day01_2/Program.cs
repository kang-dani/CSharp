using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //숫자 데이터 형식 : 정수와 실수를 다룰 때 사용하는 다양한 타입
            int integerNum = 10;            //정수 데이터
            float floatNum = 3.14f;         //단정밀도 실수
            double doubleNum = 3.141592;    //배정밀도 실수

            Console.WriteLine(integerNum); Console.WriteLine(floatNum); Console.WriteLine(doubleNum);
            Console.WriteLine("--------------------------------------------------");

            //정수 데이터 형식 : 소수점이 없는 숫자를 표현
            int intValue = -100;            //4바이트 크기의 정수
            long longValue = 1234567890L;   //8바이트 크기의 정수

            Console.WriteLine(intValue);    //출력 : -100
            Console.WriteLine(longValue);   //출력 : 1234567890
			Console.WriteLine("--------------------------------------------------");

            //부호 있는 정수 : 음수와 양수를 모두 표현 가능
            sbyte signedByte = -50;         //1바이트 크기
            short signedShort = -32000;     //2바이트 크기
            int signedInt = -2000000000;    //4바이트 크기

			Console.WriteLine(signedByte);  //출력 : -50
			Console.WriteLine(signedShort); //출력 : -32000
			Console.WriteLine(signedInt);   //출력 : -2000000000
			Console.WriteLine("--------------------------------------------------");

            //부호 없는 정수 : 양수만 표현 가능
            byte unsignedByte = 255;        //1바이트 크기
			ushort unsignedShort = 65000;     //2바이트 크기
			uint unsignedInt = 4000000000;    //4바이트 크기

			Console.WriteLine(unsignedByte);  //출력 : 255
			Console.WriteLine(unsignedShort); //출력 : 65000
			Console.WriteLine(unsignedInt);   //출력 : 4000000000
			Console.WriteLine("--------------------------------------------------");


			//실수형 데이터 형식 : 양수만 표현 가능
			float singlePrecision = 3.14f;                      //단정밀도 실수
			double doublePrecision = 3.14159239221;             //배정밀도 실수 (8바이트)
			decimal highPrecision = 3.1412938298328989231m;     //고정밀도 (16바이트)

			Console.WriteLine(singlePrecision); //출력 : 3.14
			Console.WriteLine(doublePrecision); //출력 : 3.14159239221
			Console.WriteLine(highPrecision);   //출력 : 3.1412938298328989231
			Console.WriteLine("--------------------------------------------------");

            //char 형식 : 단일 문자를 표현
            char letter = 'A';                  //문자 'A' 저장
            char symbol = '#';                  //특수기호 '#' 저장
            char number = '9';                  //숫자 형태의 문자 저장 (문자 '9', 숫자 9 아님)

			Console.WriteLine(letter);          //출력 : A
			Console.WriteLine(symbol);          //출력 : #
			Console.WriteLine(number);          //출력 : 9
			Console.WriteLine("--------------------------------------------------");

			//string 형식 : 여러 문자를 표현
			string greeting = "Hello World";    //문자열 저장
			string name = "Alice";

			Console.WriteLine(greeting);        //출력 : Hello World
			Console.WriteLine(name);            //출력 : Alice
			Console.WriteLine(greeting + " " + name);	//출력 : Hello World Alice
			Console.WriteLine("--------------------------------------------------");

			//bool 형식 : 참 (true ) = 1, 거짓 (false) = 0
			bool isRunning = true;				//프로그램 실행 상태
			bool isFinished = false;            //프로그램 종료 상태

			Console.WriteLine(isRunning);		//출력 : True
			Console.WriteLine(isFinished);      //출력 : False
			Console.WriteLine("--------------------------------------------------");

			//닷넷 형식 : 기본 형식의 닷넷 표현
			System.Int32 number1 = 123;			//닷넷 int 형식
			System.String text = "Hello";		//string 의 닷넷 형식
			System.Boolean flag = true;			//bool의 닷넷 형식

			Console.WriteLine(number1);         //출력 : 123
			Console.WriteLine(text);		    //출력 : Hello
			Console.WriteLine(flag);		    //출력 : True
			Console.WriteLine("--------------------------------------------------");

			//int 래퍼 형식의 메서드 활용
			int number2 = 123;
			string numberAsString = number.ToString();  //정수를 문자열로 변환

			//bool의 래퍼 형식
			bool flag1 = true;
			string flagAsString = flag1.ToString();      //논리값을 문자열로 변환

			Console.WriteLine(flag1);					//출력 : true
			Console.WriteLine(flagAsString);            //출력 : true
		}
    }
}
