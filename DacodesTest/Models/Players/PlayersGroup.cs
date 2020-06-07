using System.Collections.Generic;

namespace DacodesTest.Models.Players
{
    public class PlayersGroup : List<DataPlayer>
    {
        public string Heading { get; set; }

        public PlayersGroup(List<DataPlayer> collection)
        {
            this.AddRange(collection);
        }
    }
}
