using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroHelp
{
    internal class ChoiceSystemAbilities
    {
        public static int[] GetRandomAbilities()
        {
            int[] abilitiesNumbers = new int[6];
            int min = 0;
            for(int i = 0; i < 6; i++)
            {
                abilitiesNumbers[i] = RandomAbilities.GetAbility();
            }
            //for(int i = 0; i < abilitiesNumbers.Length; i++)
            //{
            //    min = abilitiesNumbers[i];
            //}
            //if (min < 73)
            //{
            //    GetRandomAbilities(); //stackoverflowexc
            //}
            Show(abilitiesNumbers);
            return abilitiesNumbers;
        }

        public static void Show(int[] array)
        {
            foreach(int i in array)
            {
                Console.WriteLine(i+"\t");
            }
        }
    }
}
