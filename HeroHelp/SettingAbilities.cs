using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroHelp
{
    class SettingAbilities
    {
        private static List<int> Ability = new List<int>();
        public static void SetProps()
        {
            Character.Strength = Ability[0];
            Character.Dexterity = Ability[1];
            Character.Constitution = Ability[2];
            Character.Intelligence = Ability[3];
            Character.Wisdom = Ability[4];
            Character.Charisma = Ability[5];
        }
        public static void SetAbilitiesByUser(List<int> abilities)
        {   
            int ability = 0;
            int temp = 0;
            while (abilities.Count != 0)
            {
                for (int i = 0; i < Enum.GetNames(typeof(EAbility)).Length; i++)
                {
                    Console.WriteLine("Какое значение вы хотите поставить в {0}", Enum.GetName(typeof(EAbility), i));
                    ability = Int32.Parse(Console.ReadLine()); //try catch format exception                    
                    foreach (int item in abilities)
                    {
                        if (item == ability)
                        {
                            temp = item;
                            break;
                        }
                        else temp = 0;
                    }
                    if (temp == ability)
                    {
                        Ability.Add(ability);
                        abilities.Remove(ability);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неимеющееся значение!");
                        i--;
                    }
                    if (abilities.Count != 0)
                    {   
                        OutputUser.ShowRestAbilities(abilities);
                    }
                }
            }
            OutputUser.ShowSetAbilities(Ability);
        }

    }
}
