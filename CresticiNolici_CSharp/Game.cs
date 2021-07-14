using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CresticiNolici_CSharp
{
    public class Game
    {
        public Message Info;
        public Message Error;

        public string Player1_Name;
        public string Player2_Name;

        public void Play()
        {
                Info?.Invoke("Противостояние игроков " + Player1_Name +" против "+ Player2_Name + "начинается");
                if (Console.ReadKey().Key != ConsoleKey.Escape)
                {
                    Console.WriteLine("\n\n\n\n\n\n\n\n");
                    for (int i = 6; i >= 0; i -= 3)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (j != 2)
                            {
                                Console.WriteLine("   |   |   ");
                            }
                        }
                        if (i != 0) Console.WriteLine("--- --- ---");
                    }
                }
                Console.ReadLine();
        }

		public void Exit()
        {
            Console.WriteLine("До новых встреч!");
            return;
        }
    }
}
