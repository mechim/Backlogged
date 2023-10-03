using System;
using static Content.Game;

namespace Content{
	public class Review{
		public int reviewScore;
		public bool like;
		public string reviewText;
		public DateTime reviewDate;
		public Content.Game reviewGame;

		public Review(int score, bool like, string text, DateTime date, Content.Game game){
			this.reviewScore = score;
			this.like = like;
			this.reviewText = text;
			this.reviewDate = date;
			this.reviewGame = game;

			Data.ReviewLibrary.reviewLibrary.Add(this);
		}
	}
}
