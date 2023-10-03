using System;
using static Content.Game;
using static Data.GameLibrary;
using static Data.ReviewLibrary;
using static Content.Review;
using static Manager.ReviewManager;
using static Manager.GameManager;
using static Data.SaveLoad;
using static App.Menu;
namespace App{
	class Backlogged{
		public static void Main(string[] args)
		{
			Console.Clear();
			Data.SaveLoad.Load();
			while (true){
				App.Menu.MainMenu();
			}
			

		}
	}
}

