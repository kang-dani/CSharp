using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_Quest1
{
    class Program
    {
        public class Warrior
        {
            public string Name { get; set; }
			public int Score { get; set; }
			public double Stregth { get; set; }
        }
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior.Name = "멋사";
            warrior.Score = 32;
            warrior.Stregth = 23.3;

            Console.WriteLine($"이름 : {warrior.Name}");
            Console.WriteLine($"점수 : {warrior.Score}");
            Console.WriteLine($"힘 : {warrior.Stregth}");
        }
    }
}
