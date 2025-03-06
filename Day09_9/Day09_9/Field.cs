using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Day09_9
{
    public class Field
    {
        Player m_pPlayer = null;
        //몬스터 생성
        Monster m_pMonster = null;

		//플레이어가 maingame에서 생성한 거 갖고 오기
		//플레이어가 필드에서 전투를 하면 데미지 입고 , hp가 까짐

		public void SetPlayer(Player _pPlayer) { m_pPlayer = _pPlayer; }

        public void Progress()
        {
            int iInput = 0;
            
            while(true)
			{
				
				DrawMap();
				iInput = int.Parse(Console.ReadLine());
				if(iInput == 4)
				{
					break;
				}
				if(iInput <= 3)
				{
					//몬스터를 만들고
					//1 번일 때 초보 몬스터
					//2 번일 때 중급 몬스터
					//3 번일 때 고급 몬스터
					CreateMonster(iInput);

					//싸우기
					Fight();
				}
			}

			void DrawMap()
			{
				Console.Clear();
				m_pPlayer.Render();
				Console.WriteLine("1. 초보맵");
				Console.WriteLine("2. 중수맵");
				Console.WriteLine("3. 고수맵");
				Console.WriteLine("4. 전단계");
				Console.WriteLine("==============================");
				Console.Write("맵을 선택하세요 : ");
			}
		}
		public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
		{
			pMonster = new Monster()
			{
				strName = _strName,
				iHp = _iHp,
				iAttack = _iAttack
			};
		}
		public void CreateMonster(int input)
		{
			switch (input)
			{
				case 1:
					//공장처럼 찍어내준다.
					//디자인 패턴 중 하나인 팩토리 메서드 패턴
					Create("초보몹", 30, 3, out m_pMonster);
					break;
				case 2:
					Create("중수몹", 60, 6, out m_pMonster);
					break;
				case 3:
					Create("고수몹", 90, 9, out m_pMonster);
					break;
			}
		}

		public void Fight()
		{
			int iInput = 0;

			while(true)
			{
				m_pPlayer.Render();
				m_pMonster.Render();

				Console.Write("1.공격 2.도망 : ");
				iInput = int.Parse(Console.ReadLine());

				if (iInput == 1)
				{
					//몬스터가 플레이어 공격
					m_pPlayer.SetDamage(m_pMonster.iAttack);
					//플레이어가 몬스터 공격
					m_pMonster.SetDamage(m_pPlayer.iAttack);

					if (m_pPlayer.iHp <= 0)
					{
						if(m_pPlayer.strName == "기사")
						{
							m_pPlayer.iHp = 100;
						}
						else if (m_pPlayer.strName == "마법사")
						{
							m_pPlayer.iHp = 90;
						}
						else if (m_pPlayer.strName == "도둑")
						{
							m_pPlayer.iHp = 85;
							break;
					}
				}

				if (iInput == 2 || m_pMonster.iHp <= 0)
				{
					m_pMonster = null;
					break;
				}
			}
		}


		public Field() { }
		~Field() { }
	}
}
