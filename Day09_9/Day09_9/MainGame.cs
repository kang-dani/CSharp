using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_9
{
	public class MainGame
	{
		public Player m_pPlayer = null;
		//필드 객체
		public Field m_pField = null;


		//초기화를 해주는 함수
		public void Initialize()
		{
			//플레이어 생성 및 직업 선택
			m_pPlayer = new Player();
			m_pPlayer.SelectJob(m_pPlayer);
		}

		//게임의 전체적인 과정 관리
		public void Progress()
		{
			int iInput = 0;
			while (true)
			{
				Console.Clear();
				m_pPlayer.Render();
				Console.Write("1.사냥터 2.종료 : ");
				iInput = int.Parse(Console.ReadLine());
				if (iInput == 2)
				{
					break;
				}

				if(iInput == 1)
				{
					//사냥터 구현
					if(m_pField == null)
					{
						m_pField = new Field();
						//필드 갈 때 플레이어 정보를 넘겨줌
						m_pField.SetPlayer(m_pPlayer);
					}
					m_pField.Progress();
				}
			}
		}

		public MainGame() { }
		~MainGame() { }
	}
}
