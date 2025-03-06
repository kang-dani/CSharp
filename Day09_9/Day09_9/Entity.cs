using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_9
{
    public abstract class Entity
    {
		public string strName;
		public int iAttack;
		public int iHp;

		//데미지 입기
		public abstract void SetDamage(int _iAttack);
		public abstract void Render();
	}
}
