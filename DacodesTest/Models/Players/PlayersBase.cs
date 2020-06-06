using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DacodesTest.Models.Players
{
    public abstract class PlayersBase
    {
        [JsonProperty("team")]
        public Team Team { get; set; }
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class Team
    {
        [JsonProperty("forwards")]
        public List<Forward> Forwards { get; set; }
        [JsonProperty("centers")]
        public List<Center> Centers { get; set; }
        [JsonProperty("defenses")]
        public List<Defens> Defenses { get; set; }
        [JsonProperty("goalkeepers")]
        public List<Goalkeeper> Goalkeepers { get; set; }
        [JsonProperty("coaches")]
        public List<Coach> Coaches { get; set; }
    }

    public class Coach
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
        public object Weight { get; set; }
        [JsonProperty("height")]
        public object Height { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("role_short")]
        public string RoleShort { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class Goalkeeper
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
        public int Weight { get; set; }
        [JsonProperty("height")]
        public double Height { get; set; }
        [JsonProperty("position")]
        public string Position { get; set; }
        [JsonProperty("number")]
        public int Number { get; set; }
        [JsonProperty("position_short")]
        public string PositionShort { get; set; }
        [JsonProperty("last_team")]
        public string LastTeam { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class Defens
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
        public int Weight { get; set; }
        [JsonProperty("height")]
        public double Height { get; set; }
        [JsonProperty("position")]
        public string Position { get; set; }
        [JsonProperty("number")]
        public int Number { get; set; }
        [JsonProperty("position_short")]
        public string PositionShort { get; set; }
        [JsonProperty("last_team")]
        public string LastTeam { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class Center
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
        public int Weight { get; set; }
        [JsonProperty("height")]
        public double Height { get; set; }
        [JsonProperty("position")]
        public string Position { get; set; }
        [JsonProperty("number")]
        public int Number { get; set; }
        [JsonProperty("position_short")]
        public string PositionShort { get; set; }
        [JsonProperty("last_team")]
        public string LastTeam { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class Forward
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
        public int Weight { get; set; }
        [JsonProperty("height")]
        public double Height { get; set; }
        [JsonProperty("position")]
        public string Position { get; set; }
        [JsonProperty("number")]
        public int Number { get; set; }
        [JsonProperty("position_short")]
        public string PositionShort { get; set; }
        [JsonProperty("last_team")]
        public string LastTeam { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
