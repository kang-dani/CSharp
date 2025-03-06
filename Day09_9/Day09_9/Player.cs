using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_9
{
    public class Player : Entity
    {
        public Player player = null;

		//플레이어 정보를 외부에서 볼 수 있는 함수

		//직업 선택
		public void SelectJob(Player _player)
		{
			player = _player;
			Console.Write("직업을 선택하세요 (1.기사 2.마법사 3.도둑) : ");
			int iInput = 0;
			iInput = int.Parse(Console.ReadLine());
			switch (iInput)
			{
				case 1:
					player.strName = "기사";
					player.iAttack = 10;
					player.iHp = 100;
					break;
				case 2:
					player.strName = "마법사";
					player.iAttack = 15;
					player.iHp = 90;
					break;
				case 3:
					player.strName = "도둑";
					player.iAttack = 13;
					player.iHp = 85;
					break;
			}
		}

		public override void Render()
		{
			Console.WriteLine("===================================");
			Console.WriteLine("직업 이름 : " + player.strName);
			Console.WriteLine("체력 : " + player.iHp + "\t공격력 : " + player.iAttack);
		}

		public override void SetDamage(int _iAttack)
		{
			 player.iHp -= _iAttack;
		}

		public Player() { }
		~Player() { }
	}
}
