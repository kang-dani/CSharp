using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            //사용자 입력을 문자열 받기
                        Console.Write("나이를 입력하세요 : ");
                        string input = Console.ReadLine();      //사용자로부터 입력 받기
                        int age = int.Parse(input);             //문자열을 정수로 변환

                        Console.WriteLine($"올해는 {age}살이 되겠군요!");   //변환된 값 사용
                        Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");   //변환된 값 사용*/

            Console.Write("스킬 피해량을 입력하세요 : ");
            float ruin = float.Parse(Console.ReadLine());
            Console.Write("카드 게이지 획득량을 입력하세요 : ");
            float card = float.Parse(Console.ReadLine());
            Console.Write("각성기 피해량을 입력하세요 : ");
            float damage = float.Parse(Console.ReadLine());
            Console.Write("최대 마나량을 입력하세요 : ");
            int maxMana = int.Parse(Console.ReadLine());
			Console.Write("전투 중 마나 회복량을 입력하세요 : ");
			int fillMana = int.Parse(Console.ReadLine());
			Console.Write("비전투 중 마나 회복량을 입력하세요 : ");
			int unFFillMana = int.Parse(Console.ReadLine());
			Console.Write("이동 속도를 입력하세요 : ");
			float speed = float.Parse(Console.ReadLine());
			Console.Write("탈 것 속도 입력하세요 : ");
			float veSpeed = float.Parse(Console.ReadLine());
			Console.Write("운반 속도 입력하세요 : ");
			float carrySpeed = float.Parse(Console.ReadLine());
			Console.Write("스킬 재사용 대기시간 감소 입력하세요 : ");
			float skillTime = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
			Console.WriteLine("활동");
            Console.WriteLine("------------------------------------------------");


			Console.WriteLine($"루인 스킬 피해 {ruin}%");
            Console.WriteLine($"카드 게이지 획득량 {card}%");
            Console.WriteLine($"각성기 피해 {damage}");
            Console.WriteLine($"최대 마나 {maxMana}");
            Console.WriteLine($"전투 중 마나 회복량 {fillMana}");
            Console.WriteLine($"비전투 중 마나 회복량 {unFFillMana}");
            Console.WriteLine($"이동 속도 {speed}%");
            Console.WriteLine($"탈 것 속도 {veSpeed}%");
            Console.WriteLine($"운반 속도 {carrySpeed}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 {skillTime}%");



        }
    }
}
