using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Day09_9
{
    public class Monster : Entity
	{
        public override void Render()
		{
			Console.WriteLine("===================================");
			Console.WriteLine("몬스터 이름 : " + strName);
			Console.WriteLine("체력 : " + iHp + "\t공격력 : " + iAttack);
		}

		public override void SetDamage(int _iAttack)
		{
			iHp -= _iAttack;
		}

		public Monster() { }
		~Monster() { }
	}
}
