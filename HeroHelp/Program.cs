using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroHelp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую тебя, путник!");
            Console.WriteLine("Я твой помощник по созданию персонажа для настольной ролевой игры (далее - НРИ)");
            Console.WriteLine("на системе 2d20 (Dungeon & Dragons - далее ДнД, Pathfinder, Warcraft - далее ВК)");
            Console.WriteLine();
            // выбор 1. создать файл 2. загрузить файл 3. Выход
            Console.WriteLine("Выберите сеттинг из представленных:");
            // выбор сеттинга 1. Днд 2. ВК 3. Выход
            Console.WriteLine("Выберите систему распределения характеристик:");
            // выбор 1. Стандарт 2. 4д6-1д6 3. купить за очки (27)
            ChoiceSystemAbilities.GetRandomAbilities();

        }
    }
}
