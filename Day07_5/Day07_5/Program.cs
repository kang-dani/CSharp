using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_5
{
	class Program
	{
		static void Main(string[] args)
		{
			//stack
			Stack stack = new Stack();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);

			while (stack.Count > 0)
			{
				Console.WriteLine(stack.Pop());
			}

			//Queue

			Queue queue = new Queue();
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);

			while (queue.Count > 0)
			{
				Console.WriteLine(queue.Dequeue());
			}

			ArrayList arrayList = new ArrayList();

			arrayList.Add(1);
			arrayList.Add("Hello");
			arrayList.Add(3.13);

			//요소 접근
			Console.WriteLine("ArrayList 요소 : ");
			foreach (var item in arrayList)
			{
				Console.WriteLine(item);
			}

			arrayList.Remove(1);

			Console.WriteLine("ArrayList 요소 제거 후 : ");
			foreach (var item in arrayList)
			{
				Console.WriteLine(item);
			}

			Hashtable hashtable = new Hashtable();

			hashtable["Alice"] = 25;
			hashtable["Bob"] = 20;
			hashtable["다니"] = 23;

			Console.WriteLine("HashTable 요소 : ");

			foreach (DictionaryEntry entry in hashtable)
			{
				Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
			}

			//특정 키 값 가져오기
			Console.WriteLine($"Alice 의 나이 : {hashtable["Alice"]}");
			foreach (DictionaryEntry entry in hashtable)
			{
				Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
			}
		}
	}
}
