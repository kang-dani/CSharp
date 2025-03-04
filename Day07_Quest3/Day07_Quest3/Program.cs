using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_Quest3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();
            fruits.Add("사과");
            fruits.Add("바나나");
            fruits.Add("포도");
            Console.WriteLine("어떤 과일이 있나요?");
            for (int i = 0; i < fruits.Count; i++) Console.WriteLine(fruits[i]);
            Console.WriteLine();

            Queue<string> task = new Queue<string>();
            task.Enqueue("첫 번째 작업");
            task.Enqueue("두 번째 작업");
            task.Enqueue("세 번째 작업");
			Console.WriteLine("작업을 시작합니다.");
			while(task.Count > 0) Console.WriteLine(task.Dequeue());
			Console.WriteLine();

			Stack<int> numbers = new Stack<int>();
            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);
			Console.WriteLine("어떤 수가 들어있나요?");
			while (numbers.Count > 0) Console.WriteLine(numbers.Pop());
			Console.WriteLine();
		}
    }
}
