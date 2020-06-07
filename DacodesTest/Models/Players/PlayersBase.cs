using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DacodesTest.Models.Players
{
    public abstract class PlayersBase
    {
        [JsonProperty("forwards")]
        public List<DataPlayer> Forwards { get; set; }
        [JsonProperty("centers")]
        public List<DataPlayer> Centers { get; set; }
        [JsonProperty("defenses")]
        public List<DataPlayer> Defenses { get; set; }
        [JsonProperty("goalkeepers")]
        public List<DataPlayer> Goalkeepers { get; set; }
        [JsonProperty("coaches")]
        public List<DataPlayer> Coaches { get; set; }
    }

    public class DataPlayer
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("first_surname")]
        public string FirstSurname { get; set; }
        [JsonProperty("second_surname")]
        public string SecondSurname { get; set; }
        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }
        [JsonProperty("birth_place")]
        public string BirthPlace { get; set; }
        [JsonProperty("weight")]
        public double? Weight { get; set; }
        [JsonProperty("height")]
        public double? Height { get; set; }
        [JsonProperty("number")]
        public double? Number { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("role_short")]
        public string RoleShort { get; set; }
        [JsonProperty("position")]
        public string Position { get; set; }
        [JsonProperty("position_short")]
        public string PositionShort { get; set; }
        [JsonProperty("last_team")]
        public string LastTeam { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
