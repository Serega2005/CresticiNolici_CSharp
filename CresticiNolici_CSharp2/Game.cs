using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CresticiNolici_CSharp2
{
    public static class Game
    {
        public static void Init()
        {
            Board.Status = StatusType.Game;
        }
        public static bool CheckMove(int position)
        {
            return Board.board[position] != 'X' || Board.board[position] != 'O';
        }

    }

}
