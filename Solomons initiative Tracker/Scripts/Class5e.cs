using System.Text.Json.Serialization;

namespace Solomons_initiative_Tracker
{

    public class Class
    {
        public static List<String> list = new()
        {
          "Other",
          "Artificer",
          "Barbarian",
          "Bard",
          "BloodHunter",
          "Cleric",
          "Druid",
          "Fighter",
          "Monk",
          "Paladin",
          "Ranger",
          "Rogue",
          "Sorcerer",
          "Warlock",
          "Wizard",
        };

        public enum Job
        {
          Other,
          Artificer,
          Barbarian,
          Bard,
          BloodHunter,
          Cleric,
          Druid,
          Fighter,
          Monk,
          Paladin,
          Ranger,
          Rogue,
          Sorcerer,
          Warlock,
          Wizard,
        }
    }

}
