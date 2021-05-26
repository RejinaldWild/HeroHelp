using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroHelp
{
    internal class RandomAbilities
    {        
        private static Random RollRandom = new Random();

        // бросок кубов на 4д6
        private static List<int> RollRandoms()
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                result.Add(RollRandom.Next(1,6));
            }
            return result;
        }

        // вычитаем наименьшее значение из 4д6
        private static List<int> GetRolls()
        {
            List<int> abilities = RollRandoms();            
            List<int> resultAbilities = new List<int>();
            int count = 0;
            for (int i = 0; i < abilities.Count; i++)
            {
                resultAbilities.Add(abilities[i]);
                if (i == abilities.Min() && count ==0)
                {
                    resultAbilities.Remove(resultAbilities.Min());
                    count++;
                }
            }            
            return resultAbilities;
        }

        public static int GetAbility()
        {
            int ability = GetRolls().Sum();
            while (ability <= 6 || ability > 18)
            {
                ability = GetRolls().Sum();
            }
            return ability;
        }
    }
}
