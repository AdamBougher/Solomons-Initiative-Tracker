using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Solomons_initiative_Tracker
{
    public class Ability
    {
        public Abilities Abilitie
        {
            get; private set;
        }

        public int Score 
        {
            get; private set;
        }

        public int Modifier
        {
            get; private set;
        }

        public bool Save
        {
            get; private set;
        }

        public Ability((int score, bool save) inf)
        {
            Score = inf.score;

            Save = inf.save;

            SetMod(Score);
        }

        public void SetScore(int amt)
        {
            Score = amt;

            SetMod(Score);
        }

        public void SetSave(bool s)
        {
            Save = s;
        }

        private void SetMod(int score)
        {
            Modifier = (score - 10) / 2;

            Modifier = (int)MathF.Floor(Modifier);
        }
        
        public void SetScore(Abilities ab)
        {
            this.Abilitie = ab;
        }

        public static (int score, bool save)[] BuildAbilityScores(int[] statArr, bool[] saveArr)
        {
            ( int score, bool save)[] abilities = new ( int score, bool save)[6];
            int index = 0;

            foreach (var ability in Enum.GetValues(typeof(Abilities)).Cast<Abilities>())
            {
                abilities[index] = (new(statArr[index], saveArr[index]));
                index++;
            }

            return abilities;
        }
    }
}


[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Abilities
{
    [EnumMember(Value = "Strength")]
    Strength,
    [EnumMember(Value = "Dexterity")]
    Dexterity,
    [EnumMember(Value = "Constitution")]
    Constitution,
    [EnumMember(Value = "Intelligence")]
    Intelligence,
    [EnumMember(Value = "Wisdom")]
    Wisdom,
    [EnumMember(Value = " Charisma")]
    Charisma
}
