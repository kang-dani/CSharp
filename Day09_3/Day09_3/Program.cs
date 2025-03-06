using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_3
{
    class MyResource
    {
        ~MyResource()
        {
            Console.WriteLine("메모리에서 해제될 때 호출");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyResource my = new MyResource();
            //Garbage collecter 에 의해 소멸자 호출
        }
    }
}
