using System;
using static Data.GameLibrary;

namespace Content{
	public class Game{

		public string gameName;
		public string gameDeveloper;
		public string gamePublisher;
		public int gameReleaseYear;

		public Game(string name, string dev, string pub, int year){
			this.gameName = name;
			this.gameDeveloper = dev;
			this.gamePublisher = pub;
			this.gameReleaseYear = year;
			Data.GameLibrary.gameLibrary.Add(this);
		}

	}
}

