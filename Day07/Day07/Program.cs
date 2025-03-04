using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 종료");

            string path = Environment.GetEnvironmentVariable("PATH");
            Console.WriteLine($"PATH : {path}");
            Console.WriteLine("-------------------------------");

            //Environment.Exit(0        //프로그램 강제 종료

            Random rand = new Random();
            int randNumber = rand.Next(1, 101); //1부터 100까지
            Console.WriteLine("랜덤 숫자 : " + randNumber);
			Console.WriteLine("-------------------------------");

            Stopwatch stopwatch = Stopwatch.StartNew();
            //실행코드
            for(int i = 0; i < 100000000; i++)
            {
                Thread.Sleep(1);                //게임은 sleep으로 만들어서는 안 됨
            }
            stopwatch.Stop();
            Console.WriteLine($"for문 시간 : {stopwatch.ElapsedMilliseconds}ms");

        }
    }
}
