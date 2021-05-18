using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroHelp
{
    internal class RandomAbilities
    {
        //4d6 - 1d6
        private static int GetMin(int[] numbs) // Get minimum of rolling d6 dice
        {
            int min = 7; // max possible = 6;
            for (int i = 0; i < numbs.Length; i++)
            {
                if (numbs[i] < min)
                {
                    min = numbs[i];
                }
            }
            return min;
        }

        private static int[] RollRandom()
        {
            int[] result = new int[4];
            Random RollRandom = new Random();
            for (int i = 0; i < 4; i++)
            {
                result[i] = RollRandom.Next(1,6);
            }
            return result;
        }

        private static int[] GetRolls()
        {
            int[] abilities = RollRandom();
            int minAbility = GetMin(abilities);
            int[] resultAbilities = new int[abilities.Length - 1];            
            Array.Sort(abilities);
            for (int i = 1; i < abilities.Length; i++)
            {
                resultAbilities[i - 1] = abilities[i];
            }
            return resultAbilities;
        }

        public static int GetAbility()
        {
            int ability = 0;
            int[] rolls = GetRolls();
            for (int i = 0; i < rolls.Length; i++)
            {
                ability += rolls[i];
            }
            if (ability <= 6 || ability > 18)
            {
                GetAbility();
            }
            return ability;
        }
    }
}
