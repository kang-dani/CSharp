using AnimalCrossing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnimalCrossing
{ 
	class Logo
	{
		string[] Logos = new string[]
		{
			"  ____       __  __      ______                  ______      __",
			"/\\  _  \\    /\\ \\/\\ \\    /\\__  _\\     /'\\_/`\\    /\\  _  \\    /\\ \\       ",
			"\\ \\ \\L\\ \\   \\ \\ `\\\\ \\   \\/_\\ /\\ \\   /\\      \\   \\ \\ \\L\\ \\   \\ \\ \\      ",
			" \\ \\  __ \\   \\ \\ , ` \\     \\ \\ \\    \\ \\ \\__\\ \\   \\ \\  __ \\   \\ \\ \\  __ ",
			"  \\ \\ \\/\\ \\   \\ \\ \\`\\ \\     \\_\\ \\__  \\ \\ \\_/\\ \\   \\ \\ \\/\\ \\   \\ \\ \\L\\ \\",
			"   \\ \\_\\ \\_\\   \\ \\_\\ \\_\\    /\\_____\\  \\ \\_\\\\ \\_\\   \\ \\_\\ \\_\\   \\ \\____/",
			"    \\/_/\\/_/    \\/_/\\/_/    \\/_____/   \\/_/ \\/_/    \\/_/\\/_/    \\/___/ ",
			" ",
			" ____                                                               ",
			"/\\  _`\\                                    __                    ",
			"\\ \\ \\/\\_\\   _ __    ___     ____    ____  /\\_\\     ___       __  ",
			" \\ \\ \\/_/_ /\\`'__\\ / __`\\  /',__\\  /',__\\ \\/\\ \\  /' _ `\\   /'_ `\\ ",
			"  \\ \\ \\L\\ \\\\ \\ \\/ /\\ \\L\\ \\/\\__, `\\/\\__, `\\ \\ \\ \\ /\\ \\/\\ \\ /\\ \\L\\ \\",
			"   \\ \\____/ \\ \\_\\ \\ \\____/\\/\\____/\\/\\____/  \\ \\_\\\\ \\_\\ \\_\\\\ \\____ \\",
			"    \\/___/   \\/_/  \\/___/  \\/___/  \\/___/    \\/_/ \\/_/\\/_/ \\/___L\\ \\",
			"                                                             /\\____/ ",
			"                                                             \\_/__/  "
		};

		public void LogoDraw()
		{
			for (int i = 0; i < Logos.Length; i++)
			{
				Console.SetCursorPosition(5, 5 + i);
				Console.WriteLine(Logos[i]);
			}
		}
		public void GameStart()
		{
			Console.SetCursorPosition(30, 30);
			string Press = "Press ENTER to Start...";
			foreach (char c in Press)
			{
				Console.Write(c);
				Thread.Sleep(100);
			}
			Console.ReadLine();
		}

		public IntroGame nugul = new IntroGame();
	}
	class IntroGame
	{
		ClearArea clearNugulArea = new ClearArea();
		string[][] NugulVersion = new string[][]
		{
			new string[]							//머리 부분 0
			{
				"                ░▓▓▓░         ",
				"               ░▓████▓        ",
				"    ▒▓▓▒       ▒▒░░░▒█▓       ",
				"  ░▓███▓░    ░░░░░ ░░▒▓       ",
				"  ██░░░▒░░░░░░░░░░░░░▒▒       ",
				" ▓█░░░░░░░░░▒▓▓▓▓▒░░░▒▒       ",
				" ▓▓░ ░▒▒▒▓▓▓▓▓▓▓▓▓▓▓░░░       ",
				" ░▒░▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒░       ",
				"  ▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓░░      ",
				"   ▒▓▓▓▓▓▓▓▓▓▓▓▓▓▒░░░▓▓░░     ",
				"  ░▒▓▓▒░░█▓▓▓▓▓▓▓░▒▒░▒▓▒░     ",
				"  ▒▓█▒▒▒░█████▓▓▓░▒▒▒░▓▓░░    ",
				"  ▒▓█▒▒▒▒▒████▓▓▓░▒▒▒▒▓▓░░    ",
				" ░▒▓█▒▓▒▓▒███▓▓▓▓▓░░░▓▓▓░░    ",
				" ░▒▓█▒▓▓░██▓▒░░░░▓▓▓▓▓▓▒░░    ",
				" ░▒▓██░░▓█▒▒▒▒▒▒░░░▒▓▓▒▒▒░    ",
				" ░▒▓█████▓▒▒▓█▓▓▒░░░▒▒▒▒▒░    ",
				"  ▒▒▓██▓▒▒▒▓▓██▓▓▒░░▒▒▒▒▒     ",
				"  ▒▒▒▒▒▒▒▒▒▓▓███▓▒▒▒▒▒▒▒      ",
				"   ▒▒▒▒▒▒▒▒▒▓▓▓▓▓▒▒▒▒▒▒       ",
				"   ░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░        "
			},
			new string[]							// 뻐끔
			{
				"                ░▓▓▓░         ",
				"               ░▓████▓        ",
				"    ▒▓▓▒       ▒▒░░░▒█▓       ",
				"  ░▓███▓░    ░░░░░ ░░▒▓       ",
				"  ██░░░▒░░░░░░░░░░░░░▒▒       ",
				" ▓█░░░░░░░░░▒▓▓▓▓▒░░░▒▒       ",
				" ▓▓░ ░▒▒▒▓▓▓▓▓▓▓▓▓▓▓░░░       ",
				" ░▒░▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒░       ",
				"  ▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓░░      ",
				"   ▒▓▓▓▓▓▓▓▓▓▓▓▓▓▒░░░▓▓░░     ",
				"  ░▒▓▓▒░░█▓▓▓▓▓▓▓░▒▒░▒▓▒░     ",
				"  ▒▓█▒▒▒░█████▓▓▓░▒▒▒░▓▓░░    ",
				"  ▒▓█▒▒▒▒▒████▓▓▓░▒▒▒▒▓▓░░    ",
				" ░▒▓█▒▓▒▓▒███▓▓▓▓▓░░░▓▓▓░░    ",
				" ░▒▓█▒▓▓░██▓▒░░░░▓▓▓▓▓▓▒░░    ",
				" ░▒▓██░░▓█▒▒▓█▓▒░░░▒▓▓▒▒▒░    ",
				" ░▒▓█████▓▒▓▓██▓▓▒░░░▒▒▒▒░    ",
				"  ▒▒▓██▓▒▒▒▓▓███▓▓▒░░▒▒▒▒     ",
				"  ▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▒▒▒▒▒▒▒      ",
				"   ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒       ",
				"   ░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒         "
			},

			new string[]							// 꼬리 부분 2
			{
				"     ▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░   ░▓▓▓ ",
				"       ░░░▒░▓▓▓▒░░░▒░░░▒▒▓▓▓▓ ",
				"         ░░░▒▒▒░░░░░▒░▒▒▒▓██  ",
				"        ░▒░░░▒░░░░░░▒░▒▒▒▓▓░  ",
				"      ░░▒░░▒▒░░░░░░░░░▒▒▒▒░   ",
				"      ░░▒░▒▒▒▒░░░░ ░░░▒▒▒     "
			},

			new string[]							// 꼬리 부분 3
			{
				"     ▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░ ░▓▓▓▒  ",
				"       ░░░▒░▓▓▓▒░░░▒░░░▓▓▓▓▒▒ ",
				"         ░░░▒▒▒░░░░░▒░▒██▓▒▒  ",
				"        ░▒░░░▒░░░░░░▒░▒▒▓▓▒   ",
				"      ░░▒░░▒▒░░░░░░░░░▒▒▒     ",
				"      ░░▒░▒▒▒▒░░░░ ░░░▒▒▒     "
			},

			new string[]							//기본 차렷 자세 4
			{
				"     ▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░       ",
				"       ░░░▒░▓▓▓▒░░░▒░░░      ",
				"         ░░░▒▒▒░░░ ░░░▒▒▒░░  ",
				"        ░▒░░░▒░░░░░░▒░▒▒▒░▒░ ",
				"      ░░▒░░▒▒░░░░░░░░░▒▒▒░░▒ ",
				"      ░░▒░▒▒▒▒░░░░ ░░░▒▒▒▒░▒░",
			}
		};
		public void DrawIntroNugul(int motionNum)
		{
			clearNugulArea.ClearImageArea();
			switch (motionNum)
			{
				case 0: //기본 머리 + 차렷
					DrawNuguls(0, 4);
					Thread.Sleep(500);
					break;
				case 1: //말할 때
					DrawNuguls(0, 4);
					Thread.Sleep(50);
					DrawNuguls(1, 4);
					Thread.Sleep(50);
					break;
				case 2: //기본 머리 + 꼬리 흔들기
					DrawNuguls(0, 2);
					Thread.Sleep(500);
					DrawNuguls(0, 3);
					Thread.Sleep(500);
					break;
			}
		}

		public void DrawNuguls(int headIndex, int bodyIndex)
		{
			for (int i = 0; i < NugulVersion[headIndex].Length; i++)
			{
				Console.SetCursorPosition(28, 1 + i);
				Console.Write(NugulVersion[headIndex][i]);
			}
			for (int i = 0; i < NugulVersion[bodyIndex].Length; i++)
			{
				Console.SetCursorPosition(28, 21 + i);
				Console.Write(NugulVersion[bodyIndex][i]);
			}
		}

		public void IntroStory()
		{
			string[] choices = { "▷ 괜찮아, 시작할래.", "▷ 그럼 안녕!" };
			int selectIndex = 0;
			SelectMessage select = new SelectMessage();

			IntroChat message = new IntroChat();
			message.ShowDialogue("너굴", "동물의 숲 베타 버전에 온 것을 환영해구리.", this);
			message.ShowDialogue("너굴", "동물의 숲 베타 버전에서는 저장을 지원하지 않아구리.", this);
			message.ShowDialogue("너굴", "그래도 괜찮겠어?", this);
			selectIndex = select.Choice(choices);

			Console.Clear();
			if (selectIndex == 0)
			{
				return;
			}
			else
			{
				string endMessage = "다음에 또 놀러오세요!";
				Console.SetCursorPosition(30, 20);
				foreach (char c in endMessage)
				{
					Console.Write(c);
					Thread.Sleep(100);

				}
				Thread.Sleep(800);
				Environment.Exit(0);
			}
		}
		public void PlayIntro()
		{
			DrawIntroNugul(1);
			IntroStory();
		}
	}
	class ClearArea
	{
		public void ClearImageArea()
		{
			for (int i = 0; i <= 22; i++)
			{
				Console.SetCursorPosition(0, i);
				Console.Write(new string(' ', 80)); //이미지로 그려질 영역만 클리어
			}
		}
	}
	abstract class Chat
	{
		public int width = 50;
		public int height = 10;
		public int startX = 15;
		public int startY = 28;

		public virtual void DrawChatWindow()
		{
			Console.SetCursorPosition(startX, startY);
			Console.Write("╭" + new string('─', width - 2) + "╮");

			for (int i = 1; i < height - 1; i++)
			{
				Console.SetCursorPosition(startX, startY + i);
				Console.Write("│" + new string(' ', width - 2) + "│");
			}

			Console.SetCursorPosition(startX, startY + height - 1);
			Console.Write("╰" + new string('─', width - 2) + "╯");
		}

		public abstract void ShowDialogue(string speaker, string message, Object scene);
	}
	class IntroChat : Chat
	{
		public override void ShowDialogue(string speaker, string message, Object introGame)
		{
			DrawChatWindow();  // 대화창 그리기
			IntroGame intro = (IntroGame)introGame;

			Console.SetCursorPosition(startX + 2, startY + 1);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write($"───✿ [{speaker}] ✿───");
			Console.ResetColor();

			int textX = startX + 2;  // 글자 출력 시작 위치 (좌측 여백)
			int textY = startY + 3;  // 대화창 내부 첫 줄

			int maxWidth = width - 28;  // 한 줄에 출력할 수 있는 최대 글자 수
			int charCount = 0;         // 현재 줄에서 출력한 문자 수

			Console.SetCursorPosition(textX, textY);

			foreach (char c in message)
			{
				int currentCursorLeft = Console.CursorLeft;

				Console.Write(c);
				intro.DrawIntroNugul(1);  // 너굴이 말하는 모션 유지

				charCount++;
				if (charCount > maxWidth)
				{
					charCount = 0;
					textX = startX + 2;
					textY++;

					Console.SetCursorPosition(textX, textY);
				}
				else
				{
					Console.SetCursorPosition(currentCursorLeft + 2, textY);
				}
				Thread.Sleep(10);
			}
			Console.SetCursorPosition(startX + width / 2 - 7, startY + height - 2);
			Console.Write("▶ Press Enter ◀");

			// Enter를 누를 때까지 기다림
			while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

		}
	}
	class DriveChat : Chat
	{
		public override void ShowDialogue(string speaker, string message, Object game)
		{
			DrawChatWindow();  // 대화창 그리기
			DriveIntro intro = (DriveIntro)game;

			Console.SetCursorPosition(startX + 2, startY + 1);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write($"───✿ [{speaker}] ✿───");
			Console.ResetColor();

			int textX = startX + 2;  // 글자 출력 시작 위치 (좌측 여백)
			int textY = startY + 3;  // 대화창 내부 첫 줄

			int maxWidth = width - 28;  // 한 줄에 출력할 수 있는 최대 글자 수
			int charCount = 0;         // 현재 줄에서 출력한 문자 수

			Console.SetCursorPosition(textX, textY);

			foreach (char c in message)
			{
				int currentCursorLeft = Console.CursorLeft;

				Console.Write(c);
				intro.DrawDrive();
				charCount++;
				if (charCount > maxWidth)
				{
					charCount = 0;
					textX = startX + 2;
					textY++;
					Console.SetCursorPosition(textX, textY);
				}
				else
				{
					Console.SetCursorPosition(currentCursorLeft + 2, textY);
				}

			}
			Console.SetCursorPosition(startX + width / 2 - 7, startY + height - 2);
			Console.Write("▶ Press Enter ◀");

			// Enter를 누를 때까지 기다림
			while (Console.ReadKey(true).Key != ConsoleKey.Enter) { intro.DrawDrive(); }

		}

	}
	class SelectMessage
	{
		public int Choice(string[] input)
		{
			DriveChat message = new DriveChat();
			string[] choices = input;
			int selectedIndex = 0;
			bool choiceMode = false;

			while (!choiceMode)
			{
				for (int i = 0; i < choices.Length; i++)
				{
					Console.SetCursorPosition(message.startX + message.width / 2 - 7, message.startY + message.height - (3 - i));
					if (i == selectedIndex)
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write(choices[i].Replace("▷", "▶"));
						Console.ResetColor();
					}
					else
					{
						Console.Write(choices[i]);
					}
				}
				ConsoleKeyInfo key = Console.ReadKey(true);
				switch (key.Key)
				{
					case ConsoleKey.UpArrow:
						selectedIndex = (selectedIndex - 1 + choices.Length) % choices.Length;
						break;
					case ConsoleKey.DownArrow:
						selectedIndex = (selectedIndex + 1) % choices.Length;
						break;
					case ConsoleKey.Enter:
						choiceMode = true;
						return selectedIndex;
				}
			}
			return selectedIndex;
		}
	}
	class DriveIntro
	{
		string[][] image = new String[][]
		{
			new string[]
			{
				"                                                                                ",
				"                                                                                ",
				"                                                                                ",
				"                                                                                ",
				"                                                                                ",
				"                                                                                ",
				"                                                                                ",
				"                                                                                ",
				"                     ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓                    ",
				"                     ┃ /       /       /            /      ┃                    ",
				"                     ┃/  *    /       /    /       /  *    ┃                    ",
				"                     ┃        *           /    *           ┃                    ",
				"                     ┃     /        *       /     *      / ┃                    ",
				"                     ┃    /           /    /            /  ┃                    ",
				"                     ┃     /                /            / ┃                    ",
				"                     ┃ /       *       /             /  /  ┃                    ",
				"                     ┃/      *        /      *      /      ┃                    ",
				"                     ┃   *                 /           *   ┃                    ",
				"                     ┃        *           /                ┃                    ",
				"                     ┃     /        *       /       *    / ┃                    ",
				"                     ┃    /     *          /   *        /  ┃                    ",
				"                     ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛                    ",
				"                                                                                ",
				"                                                                                ",
			},

			new string[]
			{
				"                                                                                ",
				"                                                                                ",
				"                                                                                ",
				"                                                                                ",
				"                                                                                ",
				"                                                                                ",
				"                                                                                ",
				"                                                                                ",
				"                     ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓                    ",
				"                     ┃ /       /       /            /      ┃                    ",
				"                     ┃   *                 /          *    ┃                    ",
				"                     ┃        *                *           ┃                    ",
				"                     ┃     /        *       /     *      / ┃                    ",
				"                     ┃          /     /           /        ┃                    ",
				"                     ┃     /                /            / ┃                    ",
				"                     ┃ /       *       /             /     ┃                    ",
				"                     ┃       *               *             ┃                    ",
				"                     ┃   *        /        /           *   ┃                    ",
				"                     ┃        *                  /         ┃                    ",
				"                     ┃     /        *       /       *    / ┃                    ",
				"                     ┃          *              *           ┃                    ",
				"                     ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛                    ",
				"                                                                                ",
				"                                                                                ",
			}
		};

		public void DrawDrive()
		{
			ClearArea clearDriveArea = new ClearArea();
			clearDriveArea.ClearImageArea();
			for (int i = 0; i < image[0].Length; i++)
			{
				Console.SetCursorPosition(1, 0 + i);
				Console.Write(image[0][i]);
			}
			Thread.Sleep(100);
			clearDriveArea.ClearImageArea();
			for (int i = 0; i < image[1].Length; i++)
			{
				Console.SetCursorPosition(1, 0 + i);
				Console.Write(image[1][i]);
			}
			Thread.Sleep(100);
		}

		public void DriveMessageChat()
		{
			DateTime time = DateTime.Now;
			DriveChat message = new DriveChat();
			SelectMessage select = new SelectMessage();
			string[] choices = { "▷ 맞아.", "▷ 틀려." };
			string[] choices1 = { "▷ 그러게.", "▷ 그렇지도 않은데." };

			int selectNum = 0;

			message.ShowDialogue("운전수", "저, 손님...", this);
			message.ShowDialogue("운전수", $"오늘이 {time} 맞나?", this);
			selectNum = select.Choice(choices);
			if(selectNum == 0)
			{
				message.ShowDialogue("운전수", "그럼 됐어. 원래 이 시계가 자주 먹통이 되거든.", this);
			}
			else
			{
				message.ShowDialogue("운전수", "그럴리가 없는데... 거짓말이지?", this);
			}
			message.ShowDialogue("운전수", "그러고 보니... 비가 참말로 오래도 내리네...", this);
			selectNum = select.Choice(choices1);
			if(selectNum == 0)
			{
				message.ShowDialogue("운전수", "오랜만에 멀리까지 나왔는데 역시 세상 일은 쉽지 않지?", this);
			}
			else
			{
				message.ShowDialogue("운전수", "뭐! 사람마다 느끼는 건 다른 법이니까", this);
			}
			message.ShowDialogue("운전수", "그런데 손님 이름은 뭔가-?", this);

		}

		public void PlayDrive()
		{
			DriveMessageChat();
		}

	}
	class NPC
	{

	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.SetWindowSize(80, 40);                  //콘솔 창 크기 설정
			Console.SetBufferSize(80, 40);                  //콘솔 버퍼 크기도 설정 (스크롤 없이 고정된 창 유지)

			Console.CursorVisible = false;                  //커서 숨기기

			Console.Clear();                                //화면 지우기
			Logo logo = new Logo();
			logo.LogoDraw();
			logo.GameStart();

			Console.Clear();
			logo.nugul.PlayIntro();

			DriveIntro driveIntro = new DriveIntro();
			driveIntro.PlayDrive();

		}
	}
}