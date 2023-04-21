using проект2;
using static System.Console;

//Title = "Kingdom Of Darkness";
CursorVisible = false;
//задаем размер окна
try
{
    WindowWidth = 135;
    WindowHeight = 35;

}
catch
{
    WriteLine("Нельзя сделать больше");
    WriteLine("Рекомендуется играть в разрешение по умолчанию");
    ConsoleUtils.WaitForKeyPress();
}

Game myGame = new Game();
myGame.Start();


//string[] option = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", };
