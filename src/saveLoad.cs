using System;
using System.IO;
using static Data.ReviewLibrary;
using static Data.GameLibrary;

namespace Data{
	public static class SaveLoad{
		private static string fileName = "backloggedData.txt";
		private static string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		private static string fullPath = Path.Combine(docPath, fileName);
			public static void Save(){
				using (StreamWriter outputFile = new StreamWriter(fullPath)){
					outputFile.WriteLine("Games");
					foreach (Content.Game game in Data.GameLibrary.gameLibrary){
						outputFile.WriteLine(game.gameName);
						outputFile.WriteLine(game.gameDeveloper);
						outputFile.WriteLine(game.gamePublisher);
						outputFile.WriteLine(game.gameReleaseYear);
					}
					outputFile.WriteLine("Reviews");
					foreach (Content.Review review in Data.ReviewLibrary.reviewLibrary){
						outputFile.WriteLine(review.reviewGame.gameName);
						outputFile.WriteLine(review.reviewScore);
						outputFile.WriteLine(review.like);
						outputFile.WriteLine(review.reviewText);
						outputFile.WriteLine(review.reviewDate);
					}
				}
			}

			public static void Load(){
				if (File.Exists(fullPath) && new FileInfo(fullPath).Length != 0){
					StreamReader sr = new StreamReader(fullPath);		
					var line = sr.ReadLine();
					line = sr.ReadLine();
					while (line != "Reviews"){
						var gName = line;
						var gDev = sr.ReadLine();
						var gPub = sr.ReadLine();
						var gYear = Convert.ToInt32(sr.ReadLine());
						Content.Game newGame = new Content.Game(gName, gDev, gPub, gYear);
						line = sr.ReadLine();
					}
					line = sr.ReadLine();
					while (line != null){
						var rGame = line;
						var rScore = Convert.ToInt32(sr.ReadLine());
						var rLike = Convert.ToBoolean(sr.ReadLine());
						var rText = sr.ReadLine();
						var rDate = DateTime.Parse(sr.ReadLine());
						Content.Game rGameRef = null;
						foreach(Content.Game game in Data.GameLibrary.gameLibrary){
							if (game.gameName == rGame){
								rGameRef = game;
								break;
							}
						}
						Content.Review newReview = new Content.Review(rScore, rLike, rText, rDate, rGameRef);
						line = sr.ReadLine();
					}
					sr.Close();
				}
			}
	}
}
