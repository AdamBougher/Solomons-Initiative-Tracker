using Solomons_initiative_Tracker;
using Solomons_initiative_Tracker.Properties;

namespace Solomons_initiative_Tracker
{
    public class Condition(string name, string information, Image img)
    {
        public string Name = name;
        public string Information = information;
        public Image icon = img;

        public static readonly List<Condition> Conditions =
        [
            new Condition(
                "Blinded",
                "A blinded creature can’t see and automatically fails any ability check that requires sight.\n" +
                "Attack rolls against the creature have advantage, and the creature’s attack rolls have disadvantage.",
                Resources.Blinded
                ),
            new Condition
            (
                "Charmed",
                "A charmed creature can’t attack the charmer or target the charmer with harmful abilities or magical effects.\n" +
                "The charmer has advantage on any ability check to interact socially with the creature.",
                Resources.Charmed
                ),
            new Condition
            (
                "Deafened",
                "A deafened creature can’t hear and automatically fails any ability check that requires hearing.",
                Resources.Deafened
                ),
            new Condition
            (
                "Frightened",
                "A frightened creature has disadvantage on ability checks and attack rolls while the source of its fear is within line of sight.\n" +
                "The creature can’t willingly move closer to the source of its fear.",
                Resources.Frightened
                ),
            new Condition("Grappled",
                "A grappled creature’s speed becomes 0, and it can’t benefit from any bonus to its speed.\n" +
                "The condition ends if the grappler is incapacitated (see the condition).\n" +
                "The condition also ends if an effect removes the grappled creature from the reach of the grappler or grappling effect, such as when a creature is hurled away by the thunderwave spell.",
                Resources.Grappled
                ),
            new Condition("Incapacitated","An incapacitated creature can’t take actions or reactions.", Resources.Incapacitated),
            new Condition("Invisible",
                "An invisible creature is impossible to see without the aid of magic or a special sense. For the purpose of hiding, the creature is heavily obscured. The creature’s location can be detected by any noise it makes or any tracks it leaves.\n" +
                "Attack rolls against the creature have disadvantage, and the creature’s attack rolls have advantage.",
                Resources.Invisible
                ),
            new Condition("Paralyzed",
                "A paralyzed creature is incapacitated (see the condition) and can’t move or speak.\n" +
                "The creature automatically fails Strength and Dexterity saving throws.\n" +
                "Attack rolls against the creature have advantage.\n" +
                "Any attack that hits the creature is a critical hit if the attacker is within 5 feet of the creature.",
                Resources.Paralysed
                ),
            new Condition("Petrified",
                "A petrified creature is transformed, along with any nonmagical object it is wearing or carrying, into a solid inanimate substance (usually stone). Its weight increases by a factor of ten, and it ceases aging.\r\n" +
                "The creature is incapacitated (see the condition), can’t move or speak, and is unaware of its surroundings.\r\n" +
                "Attack rolls against the creature have advantage.\r\n" +
                "The creature automatically fails Strength and Dexterity saving throws.\r\n" +
                "The creature has resistance to all damage.\r\n" +
                "The creature is immune to poison and disease, although a poison or disease already in its system is suspended, not neutralized.",
                Resources.Petrified
                ),
            new Condition("Poisoned","A poisoned creature has disadvantage on attack rolls and ability checks.", Resources.Poisoned),
            new Condition("Prone",
                "A prone creature’s only movement option is to crawl, unless it stands up and thereby ends the condition.\r\n" +
                "The creature has disadvantage on attack rolls.\r\n" +
                "An attack roll against the creature has advantage if the attacker is within 5 feet of the creature. Otherwise, the attack roll has disadvantage.",
                Resources.Prone
                ),
            new Condition("Restrained",
                "A restrained creature’s speed becomes 0, and it can’t benefit from any bonus to its speed.\r\n" +
                "Attack rolls against the creature have advantage, and the creature’s attack rolls have disadvantage.\r\n" +
                "The creature has disadvantage on Dexterity saving throws.",
                Resources.Restrained
                ),
            new Condition("Stunned",
                "A stunned creature is incapacitated (see the condition), can’t move, and can speak only falteringly.\r\n" +
                "The creature automatically fails Strength and Dexterity saving throws.\r\n" +
                "Attack rolls against the creature have advantage.",
                Resources.Stunned
                ),
            new Condition("Unconscious",
                "An unconscious creature is incapacitated (see the condition), can’t move or speak, and is unaware of its surroundings\r\n" +
                "The creature drops whatever it’s holding and falls prone.\r\n" +
                "The creature automatically fails Strength and Dexterity saving throws.\r\n" +
                "Attack rolls against the creature have advantage.\r\n" +
                "Any attack that hits the creature is a critical hit if the attacker is within 5 feet of the creature.",
                Resources.Unconscious
                ),
            new Exhaustion()
        ];

        public static Condition GetCondition(String name)
        {
           return Conditions.Where(x => x.Name == name).First<Condition>();
        }
    }

    public class Exhaustion : Condition
    {
        public int Level;

        public Exhaustion(string name = "Exhaustion", string information = "", Image? img = null) : base(name, information, img)
        {
            this.Name = name;
            this.Information = "Exhaustion is measured in six levels. An effect can give a creature one or more levels of exhaustion, as specified in the effect’s description.\n" +
                "1 \tDisadvantage on ability checks\r\n" +
                "2 \tSpeed halved\r\n" +
                "3 \tDisadvantage on attack rolls and saving throws\r\n" +
                "4 \tHit point maximum halved\r\n" +
                "5 \tSpeed reduced to 0\r\n" +
                "6 \tDeath";
            Level = 0;
            icon = Resources.Exhaustion;
        }

        public void IncreaseLevel()
        {
            Level++;
        }
    }

}
