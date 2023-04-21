using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проект2.Scenes
{
    internal class MayScene : Scene
    {

        public MayScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            string prompt = @"Запись на Май
";

            string[] option = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", };
            Menu menu = new Menu(prompt, option);

            int selectIndex = menu.Run();
            switch (selectIndex)
            {
                case 0:
                    MyGame.Start();
                    break;
                case 1:
                    ConsoleUtils.QuitConsole();
                    break;

            }
        }
    }
}
