using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroHelp
{
    internal class ChoiceSystemAbilities
    {
        public static List<int> Choose()
        {
            List<int> abilitiesNumbers = new List<int>();
            while (abilitiesNumbers != null)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        return abilitiesNumbers = GetStandart();
                    case "2":
                        return abilitiesNumbers = GetRandom();
                    case "3":
                        return abilitiesNumbers = GetPointsBuy();
                    default:
                        Console.WriteLine("Такой команды нет");
                        OutputUser.ShowSystems();
                        break;
                }
            }
            return abilitiesNumbers;
        }
        

        //выбор стандартных характеристик
        private static List<int> GetStandart()
        {
            List<int> abilitiesNumbers = new List<int> {15,14,13,12,10,8};
            OutputUser.ShowAbilities(abilitiesNumbers);
            return abilitiesNumbers;
        }

        //выбор случайных характеристик
        private static List<int> GetRandom()
        {
            List<int> abilitiesNumbers = new List<int>() {0,0,0,0,0,0};
            int min = 0;            
            while (min < 65 || min > 80) // иначе персонаж инвалид какой-то или супергерой
            {
                for (int i = 0; i < abilitiesNumbers.Count; i++)
                {
                    abilitiesNumbers[i] = RandomAbilities.GetAbility();
                }
                min = abilitiesNumbers.Sum();
            }
            OutputUser.ShowAbilities(abilitiesNumbers);
            return abilitiesNumbers;
        }

        // выбор покупки характеристик за очки
        private static List<int> GetPointsBuy()
        {
            List<int> abilitiesNumbers = new List<int>();
            PointsBuyAbilities.ShowCostAbility();
            //PointsBuyAbilities.BuyAbilities();
            return abilitiesNumbers;
        }

        
    }
}
