using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroHelp
{
    internal class PointsBuyAbilities
    {
        public static List<int> BuyAbilities()
        {
            List<int> abilitiesNumbers = new List<int>();
            int points = 27;
            return abilitiesNumbers;
        }

        public static void ShowCostAbility()
        {
            Console.WriteLine("У вас есть 27 пунктов, которые вы можете распределить");            
            int[] costAbility = new int[8];
            int[] val = new int[8];
            int count = 0;
            Console.WriteLine("Цена значений характеристик");
            for (int i = 0; i < val.Length; i++)
            {                                
                val[i] = i + 8;
                costAbility[i] = i;
                if (costAbility[i] > 5)
                {
                    count++;
                    costAbility[i] = i + count;
                }
                Console.WriteLine(val[i]+" | "+costAbility[i]);
            }            
        }  
    }
}
