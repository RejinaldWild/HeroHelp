using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroHelp
{
    enum EAbility
    {
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma
    }

    class Program
    {
        static void Main(string[] args)
        {   
            //логика и вывод отдельно

            OutputUser.ShowHello();

            // выбор 1. создать файл 2. загрузить файл 3. Выход

            OutputUser.ShowSetting();
            ChoiceSetting.ChooseSetting();
            // выбор сеттинга 1. Днд 2. ВК 3. Выход

            OutputUser.ShowSystems();

            // выбор 1. Стандарт 2. 4д6-1д6 3. купить за очки (27)

            Character user = new Character();
            ChoiceSystemAbilities.Choose();

            // установка характеристик по выбранной системе
            SettingAbilities.SetProps(SettingAbilities.SetAbilitiesByUser(ChoiceSystemAbilities.abilitiesNumbers)); //не перебор?

        }
    }
}
