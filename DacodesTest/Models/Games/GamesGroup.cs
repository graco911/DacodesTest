using System.Collections.Generic;

namespace DacodesTest.Models.Games
{
    public class GamesGroup : List<GameData>
    {
        public string Heading { get; set; }

        public GamesGroup(List<GameData> collection)
        {
            this.AddRange(collection);
        }
    }
}
