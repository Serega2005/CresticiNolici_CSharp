using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CresticiNolici_CSharp2
{
    public enum StatusType
    {
        Draw, WinX, WinO, Game
    }
    public static class Board
    {
        public static char[] board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static void PrintBoard(int position)
        {
            for(var i=0; i<Board.board.Length; i++)
            {
                CLI.PrintEmpti(position);
            }
        }
        public static StatusType Status;
    }
}
