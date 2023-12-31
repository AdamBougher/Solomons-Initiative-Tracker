using System.Text.Json.Serialization;


namespace Solomons_initiative_Tracker
{
    public class CharacterData
    {
        public string Name { get; set; }
        public Class.Job Job { get; set; }
        public int Hp { get; set; }
        public int Ac { get; set; }
        public int Speed { get; set; }
        public string Info { get; set; }


        [JsonPropertyName("Abilities")]
        [JsonInclude]
        public (int score, bool save)[] Abilities = new (int score, bool save)[6];


        public Dictionary<String, char>? Resistances = [];


        public Dictionary<Condition,bool>? Conditions = [];

        public CharacterData()
        {
            Name = "Unknown";

            Info = "No Known Info";
            
            for(int i = 0; i < 6; i++)
            {
                Abilities[i].score = 0;
                Abilities[i].save = false;
            }

        }

        [JsonConstructor]
        public CharacterData(String name, Class.Job job, int hp, int ac, int speed, String info, (int score, bool save)[] abilities, Dictionary<String,char> resistances, Dictionary<Condition, bool>? conditions)
        {
            Name = name;

            Job = job;

            Hp = hp;
            Ac = ac;

            Abilities = abilities;

            Speed = speed;

            Info = info;

            Resistances = resistances;

            Conditions = conditions;
        }
    }
}
