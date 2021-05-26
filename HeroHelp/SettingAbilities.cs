using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroHelp
{
    class SettingAbilities
    {
        public static

        public static int SetAbilities()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Какое значение вы хотите поставить в {0}", Enum.GetName(typeof(EAbility), i));
                string ability = Console.ReadLine();
                abilityNums[i] = SettingAbilities.SetAbilities(ability);
            }
        }
    }
}
