using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_7
{
	class Program
	{
		//커스텀 컬렉션

		public class SimpleCollection : IEnumerable<int>
		{
			private int[] data = { 1, 2, 3, 4, 5 };

			public IEnumerator<int> GetEnumerator()
			{
				foreach (var item in data)
				{
					yield return item;
				}
			}
			IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
		}
		static void Main(string[] args)
		{
			var collection = new SimpleCollection();

			foreach (var i in collection)
			{
				Console.WriteLine(i);
			}

		}
	}
}
