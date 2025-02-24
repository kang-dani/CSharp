using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class Program
    {
		static void Main(string[] args)
		{
			/*            //2진수를 정수로 변환
                        Console.Write("2진수를 입력하세요 : ");
                        string binaryInput = Console.ReadLine();                //문자열 입력받기
                        int decimalValue = Convert.ToInt32(binaryInput, 2);     //2진수 -> 10진수 변환

                        //정수를 이진수로 변환
                        string binaryOutput = Convert.ToString(decimalValue, 2);//10진수 -> 2진수 변환
                        Console.WriteLine($"입력한 이진수 : {binaryInput}");
                        Console.WriteLine($"10진수로 변환 : {decimalValue}");
                        Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");*/

			/*            var name = "Alice";     //문자열로 추론
                        var age = 25;           //정수로 추론
                        var isStudent = true;   //논리값으로 추론

                        Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부 : {isStudent}");*/
			/*
                        //default 키워드를 사용한 기본값 설정
                        int defaultInt = default;           //기본값 : 0
                        string defaultString = default;     //기본값 : null
                        bool defaultBool = default;         //기본값 : false

                        Console.WriteLine($"정수 기본 값 : {defaultInt}");
                        Console.WriteLine($"문자열 기본 값 : {defaultString}");
                        Console.WriteLine($"논리값 기본 값 : {defaultBool}");*/
			/*
                        int a = 5, b = 3;
                        int sum = 0;

                        sum = a + b;
                        Console.WriteLine($"합 : {sum}");        //출력 : 8

                        sum = a - b;
                        Console.WriteLine($"차 : {sum}");        //출력 : 2

                        sum = a * b;
                        Console.WriteLine($"곱 : {sum}");        //출력 : 15

                        sum = a / b;
                        Console.WriteLine($"분 : {sum}");        //출력 : 1

                        int c = 0, d = 0;
                        c = 5;
                        d = 2;

                        sum = c % d;
                        Console.WriteLine($"나머지 {sum}");       //출력 : 1*/

			/*            int number = 7;
                        int sum = 0;

                        sum = number % 2;       // 0 나오면 짝수, 아니면 홀수
                        Console.WriteLine("짝수 홀수 판별 : " + sum);
            */
			/*
                        bool isEqual = false;       //거짓0;

                        int a = 5;
                        int b = 5;

                        //관계형 연산자
                        isEqual = (a == b);         // a 랑 b 랑 같은가?

                        Console.WriteLine("같은가? " + isEqual);*/
			/*
						//단항 연산자
						int number = 5;
						bool flag = true;

						Console.WriteLine(+number);     //양수 출력 : 5
						Console.WriteLine(-number);     //음수 출력 : -5

						Console.WriteLine(!flag);       //논리 부정 출력 : false*/

			//~ 비트 반전
			//10 1010
			//   0101
			//   4바이트 0000 0000 0000 0000 0000 0000 0000 1010 을 반전시
			//          1111 1111 1111 1111 1111 1111 1111 0101 가 된다.
			/*
                        int num = 10;
                        int result = ~num;  //모든 비트 반전 : 1111 0101 결과

                        Console.WriteLine("원래 값 : " + num);
                        Console.WriteLine("~ 연산자 적용 후 : " + result);*/
			/*
                        //casting 실수형에서 정수형으로 캐스팅시에 소숫점 뒷자리는 모두 버려짐
                        double pi = 3.14;
                        int integerPi = (int)pi;    //실수형 -> 정수형으로 변환

                        Console.WriteLine(integerPi);*/

			/*            int iKor = 90;
                        int iEng = 75;
                        int iMath = 58;

                        int sum = 0;
                        float average = 0.0f;

                        sum = iKor + iEng + iMath;

                        average = (float)sum / 3;   //평균

                        Console.WriteLine("총점 : " + sum);
                        Console.WriteLine("평점 : " + average);*/
			/*
						int a = 10, b = 3;
						Console.WriteLine(a + b);
						Console.WriteLine(a - b);
						Console.WriteLine(a * b);
						Console.WriteLine(a / b);
						Console.WriteLine(a % b);*/

			/*			string firstName = "Alice";
                        string lastName = "Smith";

                        Console.WriteLine(firstName + " " + lastName); //출력*/

			/*            int a = 10;
                        a += 5;         // a = a + 5

                        Console.WriteLine(a);*/

			/*            int a = 10;
                        a += 5;                     // a = a + 5;
                        Console.WriteLine(a);

                        a -= 5;                     // a = a - 5;
                        Console.WriteLine(a);

                        a *= 5;                     // a = a * 5;
                        Console.WriteLine(a);

                        a /= 5;                     // a = a / 5;
                        Console.WriteLine(a);

                        a %= 5;                     // a = a % 5;
                        Console.WriteLine(a);*/

			/*            //quest 1 학점 평균 계산 프로그램
						int kor = 0, eng = 0, math = 0;
						float sum = 0;

						Console.Write("국어 성적을 입력하세요: ");
						kor = int.Parse(Console.ReadLine());
						Console.Write("영어 성적을 입력하세요: ");
						eng = int.Parse(Console.ReadLine());
						Console.Write("수학 성적을 입력하세요: ");
						math = int.Parse(Console.ReadLine());

						sum = ((float)(kor + eng + math)) / 3;

						Console.WriteLine(sum.ToString("F2"));

						//quest 2 비트 보수 프로그램
						int x = 0;
						int result = 0;

						Console.Write("비트 반전할 정수를 입력하세요 : ");
						x = int.Parse(Console.ReadLine());
						result = ~x;

						Console.WriteLine("입력한 수 : " + x);
						Console.WriteLine("반전 후 수 : " + result);
			*/
			/*			int b = 3;

						//전위 ++b , 후위 b++

						Console.WriteLine("b의 값은 : " + (b++));*/
			/*
						int x = 5, y = 10;


						Console.WriteLine(x == y);  // false
						Console.WriteLine(x != y);  // true
						Console.WriteLine(x < y);   // true
						Console.WriteLine(x > y);   // false
						Console.WriteLine(x >= y);  // false
						Console.WriteLine(x <= y);  //true  */
			/*
						bool a = false;
						bool b = false;
						//Not
						//!a

						b = !a;

						Console.WriteLine(b); //true */
			/*
						//비트연산자
						int x = 5; // 0101
						int y = 3; // 0011 

						Console.WriteLine(x & y); //AND : 1 (0001)
						Console.WriteLine(x | y); //OR : 7 (0111)
						Console.WriteLine(x ^ y); //XOR :6   (0110)
						Console.WriteLine(~x);    //NOT : -6 */
			/*

						int value = 4;  //0100

						Console.WriteLine(value << 1); //왼쪽이동 : 8 (1000)
						Console.WriteLine(value >> 1); //오른쪽이동: 2 (0010)*/
			/*
						int a = 10, b = 20;

						int max;

						max = (a < b) ? a : b; //삼항 연산자

						Console.WriteLine(max);*/

			/*		int key = 1;

					string str;
					str = (key == 2) ? "문이열렸습니다." : "문을 못열었습니다.";

					Console.WriteLine(str);
		*/

			/*			int result = 10 + 2 * 5; //곱셈이 덧셈보다 우선
						Console.WriteLine(result);

						int adjustedResult = (10 + 2) * 5; //괄호 우선순위 먼저계산

						Console.WriteLine(adjustedResult);*/

			/*			int score = 85;

						if (score >= 90)
						{
							Console.WriteLine("A 학점");
						}
						else
						{
							Console.WriteLine("B 학점");
						}*/
			/*
						string GameID = "멋사검존";


						if (GameID == "멋사검존")
						{
							Console.WriteLine("아이디가 일치합니다.");
						}
						else
						{
							Console.WriteLine("아이디가 일치하지 않습니다.");
						}*/

			/*			int score = 60;

						if (score >= 90)
						{
							Console.WriteLine("A 학점");
						}
						else if (score >= 80)
						{
							Console.WriteLine("B 학점");
						}
						else if (score >= 70)
						{
							Console.WriteLine("C 학점");
						}
						else
						{
							Console.WriteLine("F 학점");
						}*/

			/*			//quest 3
						Console.WriteLine("세 개의 정수를 입력합니다.");
						Console.Write("첫번째 정수 : ");
						int a = int.Parse(Console.ReadLine());			
						Console.Write("두번째 정수 : ");
						int b = int.Parse(Console.ReadLine());			
						Console.Write("세번째 정수 : ");
						int c = int.Parse(Console.ReadLine());

						int max = a;

						max = (max > b) ? max : b;
						max = (max > c) ? max : c;

						Console.WriteLine("최댓값 : " + max);*/

			/*			Console.Write("성적을 입력하세요 : ");
						int score = int.Parse(Console.ReadLine());

						if (score >= 90)
						{
							Console.WriteLine("A 학점");
						}
						else if (score >= 80)
						{
							Console.WriteLine("B 학점");
						}
						else if (score >= 70)
						{
							Console.WriteLine("C 학점");
						}
						else
						{
							Console.WriteLine("F 학점");

						}*/

			Console.WriteLine("숫자 두 개를 입력 후 연산자를 입력합니다.");
			Console.Write("첫번째 수 : ");
			int a = int.Parse(Console.ReadLine());			
			Console.Write("두번째 수 : ");
			int b = int.Parse(Console.ReadLine());
			Console.Write("연산자 : ");
			char oper = char.Parse(Console.ReadLine());

			if(oper.Equals('+'))
			{
				Console.WriteLine("결과 : "+ (a + b));
			}
			else if(oper.Equals('-'))
			{
				Console.WriteLine("결과 :  " + (a - b));
			}
			else if(oper.Equals('/'))
			{
				Console.WriteLine("결과 : " + (a / b));
			}
			else if(oper.Equals('*'))
			{
				Console.WriteLine("결과 : " + (a * b));
			}
			else 
			{
				Console.WriteLine("연산자 입력에 오류가 있었습니다.");
			}
		}
	}
}
