using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroHelp
{
    internal class ChoiceSetting
    {
        public static void ChooseSetting()
        {
            switch (Console.ReadLine())
            {
                case "1": OutputUser.SetDND();
                    break;
                case "2": OutputUser.SetWC();
                    break;
                default: Console.WriteLine("Что-то пошло не так...");
                    break;
            }
        }

        
    }
}
