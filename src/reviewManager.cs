using System;
using static Content.Review;
using static Content.Game;

namespace Manager{
	public static class ReviewManager{
		public static Content.Review ScanReview(Content.Game testGame){
			bool goodScore = false;
			int score = 0;
			while (goodScore == false){
				Console.WriteLine("== Reviewing " + testGame.gameName + " ==");
				Console.Write("Input Review Score: ");	
				score = Convert.ToInt32(Console.ReadLine());
				if (score < 1 || score > 10){
					Console.WriteLine("Input a valid score 1 - 10");
				} else {
					goodScore = true;
				}
			}

			bool goodLike = false;
			int like = 2;
			bool trueLike;

			while (goodLike == false){
				Console.Write("Give the game a Like?\n [1] Yes\n [2] No\n Like: ");
				like = Convert.ToInt32(Console.ReadLine());
				if (like == 1 || like == 2){
					goodLike = true;
				} else {
					Console.WriteLine("React approprately");
				}
			}
			if (like == 1){
				trueLike = true;
			} else {
				trueLike = false;
			}

			
			Console.WriteLine("Input Review Text:");
			string text = Console.ReadLine();

			DateTime date = DateTime.Now;

			Content.Review newReview = new Content.Review(score, trueLike, text, date, testGame);
			return newReview;
		}

		public static void PrintReviews(Content.Game game){
			Console.WriteLine("------- Your Reviews -------");
			foreach(Content.Review review in Data.ReviewLibrary.reviewLibrary){
				if(review.reviewGame.gameName == game.gameName){
					Console.WriteLine(" Date: " + review.reviewDate);
					Console.WriteLine(" Score: " + review.reviewScore);
					if(review.like){
						Console.WriteLine(" Liked");
					} else {
						Console.WriteLine(" Not Liked");
					}
					Console.WriteLine(" Text: " + review.reviewText);
					Console.WriteLine("-------------------------------");
				}
			}
		}

}
}
