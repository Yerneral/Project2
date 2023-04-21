using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using проект2.Scenes;
using static System.Console;

namespace проект2.Scenes
{
    internal class NavigationScene : Scene
    {
        public NavigationScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            string prompt = @"Выберите месяц
";
            string[] option = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь", };
            Menu mainMenu = new Menu(prompt, option);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    MyGame.MyJanuaryScene.Run();
                    ConsoleUtils.WaitForKeyPress();
                    return;
                case 1:
                    MyGame.MyFebruaryScene.Run();
                    ConsoleUtils.WaitForKeyPress();
                    return;
                case 2:
                    MyGame.MyMarchScene.Run();
                    ConsoleUtils.WaitForKeyPress();
                    return;
                case 3:
                    MyGame.MyAprilScene.Run();
                    ConsoleUtils.WaitForKeyPress();
                    return;
                case 4:
                    MyGame.MyMayScene.Run();
                    ConsoleUtils.WaitForKeyPress();
                    return;
                case 5:
                    MyGame.MyJuneScene.Run();
                    ConsoleUtils.WaitForKeyPress();
                    return;
                case 6:
                    MyGame.MyJuleScene.Run();
                    ConsoleUtils.WaitForKeyPress();
                    return;
                case 7:
                    MyGame.MyAugustScene.Run();
                    ConsoleUtils.WaitForKeyPress();
                    return;
                case 8:
                    MyGame.MySeptemberScene.Run();
                    ConsoleUtils.WaitForKeyPress();
                    return;
                case 9:
                    MyGame.MyOctoberScene.Run();
                    ConsoleUtils.WaitForKeyPress();
                    return;
                case 10:
                    MyGame.MyNovemberScene.Run();
                    ConsoleUtils.WaitForKeyPress();
                    return;
                case 11:
                    MyGame.MyDecemberScene.Run();
                    ConsoleUtils.WaitForKeyPress();
                    return;
            }   
        }

    }
}
