using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);                  //콘솔 창 크기 설정
            Console.SetBufferSize(80, 25);                  //콘솔 버퍼 크기도 설정 (스크롤 없이 고정된 창 유지)

            Console.CursorVisible = false;                  //커서 숨기기

            Console.Clear();                                //화면 지우기

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
            for(int i = 1; i <= 19; i++)
            {
				
                if(i == 10)
                {
					Console.SetCursorPosition(0, i); 
					Console.WriteLine("│                           대장장이 키우기                           │");
				}
                else
                {
                    Console.SetCursorPosition(0, i);
				    Console.WriteLine("│                                                                     │");
                }
			}
            Console.SetCursorPosition(0, 20);
			Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");

            Thread.Sleep(3000);

            Console.Clear();

            for(int x = 0; x < 30; x++)                     // 0 ~ 29 이동
            {
                Console.Clear();
                Console.SetCursorPosition(x, 10);
                Console.Write("◎");
                Thread.Sleep(100);
            }
		}
    }
}
