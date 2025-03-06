using Day08_TodayTask;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Day08_TodayTask
{
	class Champion
	{
		public string name;
		public sbyte level;
		public bool[] skills;
		public string[] skillName;
		public int mana;
		public Dictionary<char, int> manaCost;
		public Dictionary<char, string> skillDialogue;

		public Champion()
		{
			level = 1;
			skills = new bool[4];
			skillName = new string[4];
			manaCost = new Dictionary<char, int>();
		}

		public virtual void Select()
		{
			Console.WriteLine("날 선택해줘서 고맙군. 잘 해보도록 하지.");
		}

		public virtual void SkillToggle(char skill)
		{
			int index;
			switch (skill)
			{
				case 'Q': index = 0; break;
				case 'W': index = 1; break;
				case 'E': index = 2; break;
				case 'R': index = 3; break;
				default: Console.WriteLine("잘못된 스킬 입력입니다."); return;
			}

			// 궁극기(R)는 6레벨 이상만 배울 수 있음
			if (skill == 'R' && level < 6)
			{
				Console.WriteLine($"{level} 레벨에서는 궁극기를 배울 수 없습니다!");
				return;
			}

			// 1레벨일 때는 사용자가 스킬을 선택해서 배울 수 있도록 허용
			if (level == 1 && !skills[index])
			{
				Console.WriteLine($"{name}의 {skill} 스킬 {skillName[index]}을(를) 1레벨 스킬로 선택했습니다!");
				skills[index] = true;
			}
			else if (skills[index])
			{
				Console.WriteLine($"{name}의 {skill} 스킬 {skillName[index]}은 이미 활성화되어 있습니다.");
				return;
			}
		}


		public void UseSkill(char skill)
		{
			int index;
			switch (skill)
			{
				case 'Q': index = 0; break;
				case 'W': index = 1; break;
				case 'E': index = 2; break;
				case 'R': index = 3; break;
				default: Console.WriteLine("잘못된 스킬 입력입니다."); return;
			}
			if (index < 0 || index >= 4 || !skills[index])  // 스킬을 배우지 않았다면 사용 불가
			{
				Console.WriteLine($"{name}은(는) {skillName[index]}을(를) 아직 배우지 않았습니다!");
				return;
			}

			if (!manaCost.ContainsKey(skill))
			{
				Console.WriteLine("잘못된 스킬 입력입니다.");
				return;
			}

			int cost = manaCost[skill];

			if (mana >= cost)
			{
				mana -= cost;
				Console.WriteLine($"{name}의 {skillName[index]} 스킬을 사용합니다.");
				Console.WriteLine($"남은 마나 : {mana}");

				if (skillDialogue.ContainsKey(skill))
				{
					Console.WriteLine($"{name} : {skillDialogue[skill]}");
				}
			}
			else
			{
				Console.WriteLine("마나가 부족합니다.");
			}
		}



	}

	class Slayer : Champion
	{
		public Slayer()
		{
			level = 1;
			skills = new bool[4];
		}

		public override void Select()
		{
			Console.WriteLine($"{name}을 선택했습니다.");
			base.Select();
		}
	}

	class LeBlanc : Slayer
	{
		public LeBlanc()
		{
			name = "르블랑";
			mana = 400;
			skillName[0] = "악의의 인장";
			skillName[1] = "왜곡";
			skillName[2] = "환영 사슬";
			skillName[3] = "모방";
			manaCost = new Dictionary<char, int> { { 'Q', 50 }, { 'W', 60 }, { 'E', 50 }, { 'R', 50 } };

			skillDialogue = new Dictionary<char, string>
		{
			{ 'Q', "도망갈 수 없을 거예요." },
			{ 'W', "설마 내가 거짓말을 하겠어요?" },
			{ 'E', "내가 등장할 때가 됐군요." },
			{ 'R', "검은 장미단은 다시 피어날 겁니다!" }
		};
		}

		public override void Select()
		{
			base.Select();
			Console.WriteLine($"{name} : 검은 장미단은 다시 피어날 겁니다.");
		}
	}

	class Talon : Slayer
	{
		public Talon()
		{
			name = "탈론";
			mana = 400;
			skillName[0] = "녹서스식 외교";
			skillName[1] = "갈퀴손";
			skillName[2] = "암살자의 길";
			skillName[3] = "그림자 공격";
			manaCost = new Dictionary<char, int> { { 'Q', 40 }, { 'W', 40 }, { 'E', 0 }, { 'R', 0 } };
			skillDialogue = new Dictionary<char, string>
			{
				{ 'Q', "한심하군." },
				{ 'W', "저들의 피로 내 칼을 씻으리라." },
				{ 'E', "숨을 곳 따윈 없다." },
				{ 'R', "칼에 살고, 칼에 죽는다." }
			};
		}
		public override void Select()
		{
			base.Select();
			Console.WriteLine($"{name} : 칼에 살고, 칼에 죽는다.");

		}
	}

	class Zed : Slayer
	{
		public Zed()
		{
			name = "제드";
			mana = 400;
			skillName[0] = "예리한 표창";
			skillName[1] = "살아있는 그림자";
			skillName[2] = "그림자 베기";
			skillName[3] = "그림자 공격";
			manaCost = new Dictionary<char, int> { { 'Q', 75 }, { 'W', 40 }, { 'E', 40 }, { 'R', 0 } };

			skillDialogue = new Dictionary<char, string>
		{
			{ 'Q', "아무도 그림자를 피할 수 없다. 무지한 놈들." },
			{ 'W', "금기따윈 상관 안 해." },
			{ 'E', "그림자단이여. 용감하게 진실을 찾아라." },
			{ 'R', "보이지 않는 검이 가장 무서운 법." }
		};
		}

		public override void Select()
		{
			base.Select();
			Console.WriteLine($"{name} : 보이지 않는 검이 가장 무서운 법.");
		}
	}




	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("챔피언을 선택하세요.");
				Console.WriteLine("1. 르블랑, 2. 탈론, 3. 제드");
				int select = int.Parse(Console.ReadLine());

				Champion champion = null;

				switch (select)
				{
					case 1:
						champion = new LeBlanc();
						break;
					case 2:
						champion = new Talon();
						break;
					case 3:
						champion = new Zed();
						break;
					default:
						Console.WriteLine("잘못된 입력입니다.");
						break;
				}


				if (champion == null)
				{
					Console.WriteLine("잘못된 입력입니다.");
					continue;
				}

				champion.Select();
				HandleSkillActions(champion);
			}
		}

		static void HandleSkillActions(Champion champion)
		{
			while (true)
			{
				Console.WriteLine("스킬을 선택하세요. Q/W/E/R");
				char skill = char.Parse(Console.ReadLine().ToUpper());

				champion.SkillToggle(skill);
				Console.WriteLine("스킬을 사용하시겠습니까? (Y/N)");
				char use = char.Parse(Console.ReadLine().ToUpper());
				if (use == 'Y')
				{
					champion.UseSkill(skill);
				}
				else if (use == 'N')
				{
					break;
				}
			}
		}
	}
}
