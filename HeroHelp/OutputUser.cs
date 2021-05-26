using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroHelp
{
    internal class OutputUser
    {
        public static void ShowHello()
        {
            Console.WriteLine("Приветствую тебя, путник!");
            Console.WriteLine("Я твой помощник по созданию персонажа для настольной ролевой игры (далее - НРИ)");
            Console.WriteLine("на системе 2d20 (Dungeon & Dragons - далее ДнД, Pathfinder, Warcraft - далее ВК)");
            Console.WriteLine();
        }

        public static void ShowSetting()
        {
            Console.WriteLine("Выберите сеттинг из представленных:");
            Console.WriteLine("1. ДнД");
            Console.WriteLine("2. ВК");
        }

        public static void ShowSystems()
        {
            Console.WriteLine("Выберите систему распределения характеристик:");
            Console.WriteLine("1. Стандарт");
            Console.WriteLine("2. Случайный бросок кубов");
            Console.WriteLine("3. Характеристики за очки");
        }

        public static void SetDND()
        {
            Console.WriteLine("Отлично! Значит быстрее в Фаэрун!");
        }

        public static void SetWC()
        {
            Console.WriteLine("Отлично! Значит быстрее к Военному Ремеслу!");
        }

        public static void ShowAbilities(List<int> array)
        {
            Console.WriteLine("Ваши значения характеристик:");
            foreach (int i in array)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
    }
}
