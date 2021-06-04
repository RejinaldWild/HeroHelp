using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroHelp
{
    internal class PointsBuyAbilities
    {
        public static List<int> BuyAbilities(List<int> abilities)
        {
            List<int> Ability = new List<int>();
            int points = 27;
            int ability = 0;
            int temp = 0;
            while (points >= 0)
            {
                for (int i = 0; i < Enum.GetNames(typeof(EAbility)).Length; i++) // dictionary for Abilities -> Ability["Charisma"] = 15?
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
            return Ability;
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
        // метод показывающий остаток points
    }
}
