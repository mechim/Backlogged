using System;
namespace App{
	public static class Menu{
		public static void MainMenu(){
			Console.WriteLine("======= Main Menu =======");
			Console.WriteLine(" [1] View Game Library ");
			Console.WriteLine(" [2] Add Game");
			Console.WriteLine(" [3] Save and Exit");
			Console.Write(" > ");
			int choice = Convert.ToInt32(Console.ReadLine());
			switch (choice){
				case 1 : ViewGameLibrary();
				break;
				case 2 : AddGame();
				break;
				case 3 : SaveAndExit();
				break;
				default : Console.WriteLine("Invalid Option");
				break;
			}
		}

		public static void ViewGameLibrary(){
			Console.WriteLine("======= Game Library =======");
			Manager.GameManager.PrintGames();
			Console.WriteLine(" [0] Back ");
			Console.Write(" > ");
			int choice = Convert.ToInt32(Console.ReadLine());
			if (choice > 0 && choice <= Data.GameLibrary.gameLibrary.Count){
				Manager.GameManager.PrintGame(choice-1);
				Manager.ReviewManager.PrintReviews(Data.GameLibrary.gameLibrary[choice-1]);
				Console.WriteLine(" [1] Add Review");
				Console.WriteLine(" [2] Back");
				Console.Write(" > ");
				int choice1 = Convert.ToInt32(Console.ReadLine());
				switch(choice1){
					case 1 :
						Manager.ReviewManager.ScanReview(Data.GameLibrary.gameLibrary[choice-1]);
						break;
					default :
						break;
				}
			}
		}

		public static void AddGame(){
			Console.WriteLine("======= Add Game =======");
			Manager.GameManager.ScanGame();
		}

		public static void SaveAndExit(){
			Data.SaveLoad.Save();
			Environment.Exit(0);
		}
		
	}
}
