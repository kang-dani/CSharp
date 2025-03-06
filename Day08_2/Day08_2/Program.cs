using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_2
{
    class Player
    {
        public string name;
        public void Render()
        {
            Console.WriteLine("플레이어 " + name);
        }
    }
    class Wizard : Player
    {
        public string job;
        public void Render2()
        {
            Console.WriteLine("직업은 " + job + "입니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.name = "멋사";
            player.Render();

            Wizard wizard = new Wizard();
            wizard.name = "대마법사 곤듀";
            wizard.job = "마법사";
            wizard.Render();
            wizard.Render2();
        }
    }
}
