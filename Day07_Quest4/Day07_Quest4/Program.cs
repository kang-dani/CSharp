using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_Quest4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string upperCase = null;
            string replaceCase = null;
            
            upperCase = input.ToUpper();
            replaceCase = input.Replace("C#", "CSharp");


			Console.WriteLine("대문자로 변환합니다 : " + upperCase);
			Console.WriteLine("C# -> CSharp : " + replaceCase);
            Console.WriteLine("문자열 길이는 : " + input.Length);
            
            
        }
    }
}
