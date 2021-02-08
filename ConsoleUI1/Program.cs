using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI1
{
	class Program
	{
		static void Main(string[] args)
		{
			GameManager gameManager = new GameManager(new EfGameDal());

			foreach (var game in gameManager.GetGameDetails())
			{
				Console.WriteLine("GameName : {0} GameType {1} GameLauncher {2} GamePrice{3}" , game.GameDescription , game.TypeName , game.LauncherName , game.GamePrice);
			}
		}
	}
}
