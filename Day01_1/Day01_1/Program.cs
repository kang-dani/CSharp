using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//변수 선언
            int age;                        //정수형 변수
            age = 25;                       //변수에 값 저장

            Console.WriteLine(age);         //변수에 저장된 값을 출력
            Console.WriteLine("---------------------------------------------------");

            //리터럴 : 코드에서 고정된 값을 의미함
            int number = 10;                //정수형 리터럴
            double pi = 3.14;               //실수형 리터럴
            char letter = 'A';              //문자 리터럴
            string name = "Alice";          //문자열 리터럴

            Console.WriteLine(number);      //출력 : 10
            Console.WriteLine(pi);          //출력 : 3.14
            Console.WriteLine(letter);      //출력 : A
            Console.WriteLine(name);        //출력 :Alice
            Console.WriteLine("---------------------------------------------------");

            int hp = 100;
            float att = 56.7f;
            string charName = "밀리오";
            char grade = 'A';

            Console.WriteLine("캐릭터");
            Console.WriteLine("Hp : " + hp);
            Console.WriteLine("Att : " + att);
            Console.WriteLine("Character Name : " + charName);
            Console.WriteLine("Grade : " + grade);
            Console.WriteLine("---------------------------------------------------");

            //문자열
            string greeting;                //문자열 변수를 선언
            greeting = "Hello World";       //변수에 값을 저장

            //변수 값 사용
            Console.WriteLine(greeting);
			Console.WriteLine("---------------------------------------------------");

            //변수 선언과 초기화를 한 번에 수행
            int score = 100;                //정수형 변수 선언과 동시에 100으로 초기화
            double temprature = 36.5;       //실수형 변수 선언과 초기화
            string city = "Seoul";          //문자열 변수 선언과 초기화

            //변수 출력
            Console.WriteLine(score);       //출력 : 100
            Console.WriteLine(temprature);  //출력 : 36.5
            Console.WriteLine(city);        //출력 : Seoul
			Console.WriteLine("---------------------------------------------------");

            int x = 10, y = 20, z = 30;     //정수형 변수 x, y, z를 선언하고 초기화

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
			Console.WriteLine("---------------------------------------------------");

            //상수
            const double Pi = 3.141592;     //상수 Pi 선언 및 초기화
            const int MaxScore = 100;       //정수형 상수 선언

            //상수 출력
            Console.WriteLine("Pi : " + Pi);//출력 : Pi : 3.141592
            Console.WriteLine("Max Score : " + MaxScore);   //출력 : Max Score : 100*/

            //퀘스트

            int attack = 16755;
            const int MaxLife = 78103;

            int critical = 36;
            int mastery = 1017;
            int sub = 41;
            int Swiftness = 611;
            int patience = 22;
            int skill = 49;

			Console.WriteLine("  기본 특성");
            Console.WriteLine("---------------");

            Console.WriteLine("공격력 " + attack);
            Console.WriteLine("최대 생명력 " + MaxLife);
            Console.WriteLine("");

			Console.WriteLine("  전투 특성");
			Console.WriteLine("---------------");
			Console.WriteLine("치명 " + critical);
			Console.WriteLine("특화 " + mastery);
			Console.WriteLine("제압 " + sub);
			Console.WriteLine("신속 " + Swiftness);
			Console.WriteLine("인내 " + patience);
			Console.WriteLine("숙련 " + skill);
		}
    }
}
