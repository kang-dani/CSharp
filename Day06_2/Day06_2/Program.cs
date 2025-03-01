using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Day06_2
{
    class Person
    {
        private string name;    //내부 변수

        //값 설정하기 (Setter)
        public void SetName(string name) => this.name = name;
        //값 가져오기 (Getter)
        public string GetName() { return name; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SetName("멋사");
            Console.WriteLine("이름 : " + p.GetName());
        }
    }
}
