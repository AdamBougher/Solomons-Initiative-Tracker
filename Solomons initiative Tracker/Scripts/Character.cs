using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solomons_initiative_Tracker
{
    public class Character
    {
        private readonly CharacterData data;

        public String Name
        {
            get { return data.Name; }
        }
      
        public Class.Job Class
        {
            get { return data.Job; }
        }

        public int AC
        {
            get { return data.Ac; }

        }
        public String Information
        {
            get { 
                if(data.Info == string.Empty)
                {
                    return "No Information";
                }
                return data.Info; 
            }
            set { data.Info = value; }
        }

        public CharacterResource Hp;

        public int Speed
        {
            get { return data.Speed; }
            set { data.Speed = value; }
        }

        public List<Ability> AbilityScores = [];

        public int Initiative = 0;

        public Dictionary<Condition, bool> Conditions
        { 
            get { return data.Conditions;} 
            set {  data.Conditions = value; }
        }

        public Dictionary<String, char> Resistances
        {
            get { return data.Resistances;}
            set { data.Resistances = value; }
        }




        public Character(CharacterData characterData)
        {
            data = characterData;

            Hp = new(data.Hp, data.Hp);

            foreach((int score, bool save) tuple in data.Abilities)
            {
                AbilityScores.Add(new(tuple));
            }

        }
        public Character()
        {
            data = new CharacterData();

            Hp = new(0,0);
        }

        /// <summary>
        /// Damages Character, taking Resistances or valnurabilitys into account
        /// </summary>
        /// <param name="amt">Amout of damage</param>
        /// <param name="type">The Type of Damage</param>
        public void DamageCharacter(int amt, Damage type)
        {
            int dmg = amt;

            if(Resistances.TryGetValue(type.Name, out char value))
            {
                switch (value)
                {
                    case 'V': dmg = amt * 2; ; break;
                    case 'R': dmg = amt / 2; break;
                    case 'I': dmg = 0; break;
                }

                Hp.DecreaseCurrent(dmg);

            }
            else
            {
                Hp.DecreaseCurrent(dmg);
            }

        }
    }

}
