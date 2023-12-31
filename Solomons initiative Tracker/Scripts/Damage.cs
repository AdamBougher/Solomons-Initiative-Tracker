using Solomons_initiative_Tracker.Properties;

namespace Solomons_initiative_Tracker
{

    public class Damage(String name, Image img)
    {
        public String Name = name;
        public Image icon = img;

        public static readonly List<Damage> DamageTypes =
        [
            new("Acid", Resources.Acid),
            new("Bludgeoning", Resources.Bludgeoning),
            new("Cold", Resources.Cold),
            new("Fire", Resources.Fire),
            new("Force", Resources.Force),
            new("Lightning", Resources.Lightning),
            new("Necrotic", Resources.Necrotic),
            new("Piercing", Resources.Piercing),
            new("Poison", Resources.Poison),
            new("Psychic", Resources.Psychic),
            new("Radiant", Resources.Radiant),
            new("Slashing", Resources.Slashing),
            new("Thunder", Resources.Thunder)

        ];

        public static Damage GetDamage(string type)
        {
            return DamageTypes.Where(x => x.Name == type).First<Damage>();
        }
    }
}
