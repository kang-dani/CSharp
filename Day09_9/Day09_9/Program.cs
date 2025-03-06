using Day09_9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_TextRPG
{
	class Program
	{
		static void Main(string[] args)
		{
			MainGame MainGame = new MainGame();
			MainGame.Initialize();
			MainGame.Progress();
		}
	}
}
