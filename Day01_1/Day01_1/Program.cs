using System;
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
            //변수 선언
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
		}
}
