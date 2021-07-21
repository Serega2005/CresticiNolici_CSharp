using System;
using System.Threading;

namespace CresticiNolici_CSharp
{
	public class Program
	{
        static int player = 1;
        static int cis_num;
        static Game game = new Game();

        static void Main()
        {
            ConsoleKeyInfo cki;
            do
            {
                ScreenReload();
                do
                {
                    cki = Console.ReadKey(true);
                    cis_num = cki.KeyChar - 48;
                } while (cis_num < 1 || cis_num > 9);

                //  Проверяем занята ли позиция
                if (game.Free_position(cis_num))
                {
                    //  Свободна
                    //  Делаем ход
                    if (player % 2 == 0)
                    {
                        game.Move(cis_num, 'O');
                    }
                    else
                    {
                        game.Move(cis_num, 'X');
                    }
                    player++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(18, 27);
                    Console.WriteLine("\n\tПозиция занята");
                    Thread.Sleep(1500);
                    Console.ResetColor();

                }

            } while (game.GetGameStatus() == '0');
            ScreenReload();

            if (game.GetGameStatus() == 'v')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(18, 27);
                var viner = (player % 2) + 1;
                var symbol = (viner % 2) == 0 ? 'O' : 'X';
                Console.WriteLine($"Игрок {viner}: \"{symbol}\" выиграл.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(23, 27);
                Console.WriteLine("Ничья :)");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
        static void ScreenReload()
        {
            Console.Clear();
            Console.WriteLine("\t\tНачнём игру");
            game.Board();

            Console.ForegroundColor = ConsoleColor.Blue;
            if (game.GetGameStatus() == '0')
            {
                Console.SetCursorPosition(18, 27);
                Console.Write("Ходит - ");
                if (player % 2 == 0)
                {
                    Console.Write("Игрок 2: \"O\"");
                }
                else
                {
                    Console.Write("Игрок 1: \"X\"");
                }
            }
            Console.ResetColor();
        }
    }
}
		
		