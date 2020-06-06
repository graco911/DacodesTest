using Newtonsoft.Json;

namespace DacodesTest.Models.Statistics
{
	public abstract class StatisticsBase
    {
		[JsonProperty("position")]
		public int Position { get; set; }
		[JsonProperty("image")]
		public string Image { get; set; }
		[JsonProperty("team")]
		public string Team { get; set; }
		[JsonProperty("games")]
		public int Games { get; set; }
		[JsonProperty("win")]
		public int Win { get; set; }
		[JsonProperty("loss")]
		public int Loss { get; set; }
		[JsonProperty("tie")]
		public int Tie { get; set; }
		[JsonProperty("f_goals")]
		public int FGoals { get; set; }
		[JsonProperty("a_goals")]
		public int AGoals { get; set; }
		[JsonProperty("score_diff")]
		public int ScoreDiff { get; set; }
		[JsonProperty("points")]
		public int Points { get; set; }
		[JsonProperty("efec")]
		public object Efec { get; set; }
	}
}
