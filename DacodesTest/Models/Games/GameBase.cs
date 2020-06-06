using Newtonsoft.Json;
using System;

namespace DacodesTest.Models.Games
{
	public abstract class GameBase
    {
		[JsonProperty("local")]
		public bool Local { get; set; }
		[JsonProperty("opponent")]
		public string Opponent { get; set; }
		[JsonProperty("opponent_image")]
		public string OpponentImage { get; set; }
		[JsonProperty("datetime")]
		public DateTime Datetime { get; set; }
		[JsonProperty("league")]
		public string League { get; set; }
		[JsonProperty("image")]
		public string Image { get; set; }
		[JsonProperty("home_score")]
		public int HomeScore { get; set; }
		[JsonProperty("away_score")]
		public int AwayScore { get; set; }
	}
}
