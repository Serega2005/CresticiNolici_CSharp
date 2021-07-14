using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CresticiNolici_CSharp
{
	public class Program
	{
        static void Main()
        {
            Console.WriteLine("Начнём?");

            Game game = new Game();
            game.Info = PlayInfo;
            game.Error = PlayError;

            string Player1_Name = "";
            string Player2_Name = "";

            for (; ; )
            {
                int cislo = 0;

                Console.WriteLine("1. Играть", cislo);
                Console.WriteLine("2. Выйти", cislo);
                Console.WriteLine("Игрок 1 введите имя - ", Player1_Name);
                Console.WriteLine("Игрок 1 введите имя - ", Player2_Name);
                if (cislo == 1) game.Play();
                if (cislo == 2) game.Exit();
            }

            static void PlayInfo(string message)
            {
                Console.WriteLine(message);
            }
            static void PlayError(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
		
		