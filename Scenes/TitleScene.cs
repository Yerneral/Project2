using проект2.Scenes;
using static System.Console;

namespace проект2
{
    class TitleScene : Scene
    {
        string TitleArt = @"Больница
";
        public TitleScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            // WriteLine("Пролог начинается");      
            string promt = $@"{TitleArt}";

            string[] options = { "Записаться на прием", "Об игре", "Выйти" };//  строки главного меню
            Menu menu = new Menu(promt, options);
            int selectedIndex = menu.Run();
            switch (selectedIndex) // как туда попадаем
            {
                case 0:
                    MyGame.MyNavigationScene.Run();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    MyGame.MyExitScene.Run();
                    break;

            }
        }


        private void DisplayAboutInfo() // инфа об игре
        {
            Clear();
            WriteLine(@"Напишите свою историю!
");

            ConsoleUtils.WaitForKeyPress();
            Run();
        }

    }
}
