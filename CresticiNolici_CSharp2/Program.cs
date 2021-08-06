using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CresticiNolici_CSharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.Init();
            if (Game.CheckMove(1))
            {
                Board.PrintBoard(5);
            }
            CLI.PrintEnd();
        }
    }
}
