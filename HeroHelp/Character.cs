using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroHelp
{
    internal class Character
    {    
        public int Level { get; set; }
        public int ProfitionecyBonus { get; set; }
        public static int Strength { get; set; }
        public static int Dexterity { get; set; }
        public static int Constitution { get; set; }
        public static int Intelligence { get; set; }
        public static int Wisdom { get; set; }
        public static int Charisma { get; set; }
        public int Health { get; set; }        
        public string Name { get; set; }
        public string Race { get; set; }
        public string Background { get; set; }
        public string HitDice { get; set; }
        public string Feats { get; set; }
        public string Features { get; set; }
        public string Skills { get; set; }
        public string Spells { get; set; }
        public string SpellSlots { get; set; }
    }
}
