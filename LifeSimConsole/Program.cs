using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//sus
namespace LifeSimConsole
{
    internal class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int MAXIMIZE = 3;
        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(GetConsoleWindow(), MAXIMIZE);
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);

            var GameLogic = new GameLogic
                (
                rows:168,
                columns:630,
                populationSize:18
                );
            while (true) 
            {
                Console.Title = GameLogic.currentGeneration.ToString();
                var gameField = GameLogic.GetGameField();

                for (int y = 0; y < gameField.GetLength(1); y++) 
                {
                    var cells = new char[gameField.GetLength(0)];

                    for (int x = 0; x < gameField.GetLength(0); x++ ) 
                    {
                        if (gameField[x, y])
                            cells[x] = '#';
                        else
                            cells[x] = ' ';
                    }
                    Console.WriteLine(cells);
                }
                Console.SetCursorPosition(0, 0);
                GameLogic.NextGeneration();
            }

        }
    }
}
