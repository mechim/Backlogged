using System;
using static Content.Game;
namespace Manager{
	public static class GameManager{
		public static Content.Game ScanGame(){
			Console.Write("Game Name: ");
			string name = Console.ReadLine();
			Console.Write("Game Developer: ");
			string dev = Console.ReadLine();
			Console.Write("Game Publisher: ");
			string pub = Console.ReadLine();
			Console.Write("Release Year: ");
			string year = Console.ReadLine();
			
			Content.Game newGame = new Content.Game(name, dev, pub,Convert.ToInt32(year));
			return newGame;

		}
		
		public static void PrintGames(){
			var i = 0;
			foreach (Content.Game game in Data.GameLibrary.gameLibrary){
				i = i + 1;
				Console.Write(" ["+i+"] ");
				Console.WriteLine(game.gameName + " " + game.gameReleaseYear);
			}
		}

		public static void PrintGame(int index){
			Content.Game game = Data.GameLibrary.gameLibrary[index];
			Console.WriteLine("======= Game =======");
			Console.WriteLine(" Name: "+ game.gameName);
			Console.WriteLine(" Release Year: " + game.gameReleaseYear);
			Console.WriteLine(" Developer: " + game.gameDeveloper);
			Console.WriteLine(" Publisher: " + game.gamePublisher);
		}

	}
}
