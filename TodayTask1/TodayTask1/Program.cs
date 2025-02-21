using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodayTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //로딩바 시작화면
            Console.WriteLine("┌────────────────────────────────────────┐");
            Console.WriteLine("│                                        │");
            Console.WriteLine("│                                        │");
            Console.WriteLine("│           º어둠 속 진실º             │");
            Console.WriteLine("│                                        │");
            Console.WriteLine("│                                        │");
            Console.WriteLine("│                                        │");
            Console.WriteLine("│                                        │");
            Console.WriteLine("│                                        │");
            //게임 스토리 써보기
            Console.WriteLine("│ 엔터를 누르면 기억을 찾으러 들어갑니다.│");
			Console.WriteLine("│                                        │");
			Console.WriteLine("└────────────────────────────────────────┘");

			Console.ReadLine();
			Console.WriteLine("당신의 이름은? : ");
			Console.Write("나는 ...   ");
			string name = Console.ReadLine();
			Console.WriteLine("어제 있었던 일들이 기억나지 않아.");
			Thread.Sleep(3000);
			Console.WriteLine("나 왜 이러지?");
			Thread.Sleep(3000);
			Console.WriteLine("□ 엔터를 눌러 '민지'에게 전화 걸기");
            Console.ReadLine();
            Console.Clear();
			Console.WriteLine("민지 : 여보세요?");
			Thread.Sleep(3000);
			Console.WriteLine("1. 나 어제 무슨 일 있었어?");
            Console.WriteLine("2. 나 요즘 왜 이렇게 깜빡하지?");
            Console.WriteLine($"{name}의 대답은 ... (번호만 입력하세요)");
            if(Console.ReadLine() == "1")
            {
                Console.Clear();
				Console.WriteLine("민지 : 여보세요?");
				Console.WriteLine($"{name} : 나 어제 무슨 일 있었어?");
                Thread.Sleep(2000);

			}
            else
            {
				Console.Clear();
				Console.WriteLine("민지 : 여보세요?");
				Console.WriteLine($"{name} : 나 요즘 왜 이렇게 깜빡하지?");
				Thread.Sleep(3000);
				Console.WriteLine("민지 : 너 진짜... 도대체 왜 그러는데?");
				Thread.Sleep(2000);
				Console.WriteLine($"{name} : 내가 뭘 했는데?");
				Thread.Sleep(2000);
			}
			Console.WriteLine("민지 : 너 어제 난리도 아니었어. 요즘 왜 그러는 거야?");
			Thread.Sleep(2000);
			Console.WriteLine("     : 상도 뒤엎고, 술도 안 마시는 애가 기억은 왜 못하는데?");
			Thread.Sleep(2000);
			Console.WriteLine($"{name} : 엉? 내가?");
			Thread.Sleep(2000);
			Console.WriteLine("민지 : 너랑 못 다니겠다. 쪽팔려서 살 수가 없네.");
			Thread.Sleep(2000);
			Console.WriteLine($"{name} : 무슨 일인지 알려줘. 나 기억이 안 나.");
			Thread.Sleep(2000);
			Console.Clear();
			Console.WriteLine("민지 : 사실은 있잖아...");
			Thread.Sleep(2000);
			Console.WriteLine("To be Continued...");
			Console.WriteLine("엔터를 눌러 다음 이야기 기다리기.");
			Console.ReadLine();
			Console.Clear();

		}
    }
}
