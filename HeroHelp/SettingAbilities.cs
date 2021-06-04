using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroHelp
{
    class SettingAbilities
    {
        public static void SetProps(List<int> ability)
        {
            Character.Strength = ability[0];
            Character.Dexterity = ability[1];
            Character.Constitution = ability[2];
            Character.Intelligence = ability[3];
            Character.Wisdom = ability[4];
            Character.Charisma = ability[5];
        }
        public static List<int> SetAbilitiesByUser(List<int> abilityValues)
        {
            List<int> Ability = new List<int>();
            int ability = 0;
            int i = 0;
            while (abilityValues.Count != 0)
            {   
                Console.WriteLine("Какое значение вы хотите поставить в {0}", Enum.GetName(typeof(EAbility), i));
                ability = Int32.Parse(Console.ReadLine()); //try catch format exception                  
                if (abilityValues.IndexOf(ability)!=-1)
                {
                    Ability.Add(ability);
                    abilityValues.Remove(ability);
                    i++;
                }
                else
                {
                    Console.WriteLine("Вы ввели неимеющееся значение!");
                }
                if (abilityValues.Count != 0)
                {   
                    OutputUser.ShowRestAbilities(abilityValues);
                }
                
            }
            OutputUser.ShowSetAbilities(Ability);
            return Ability;
        }

    }
}
