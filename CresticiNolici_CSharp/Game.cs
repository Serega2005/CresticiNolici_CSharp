using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CresticiNolici_CSharp
{
    public class Game
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int left = 0;
        static int top = 3;
        static void CheckWin()
        {
            if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                arr[0] = 'v';
                return;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                arr[0] = 'v';
                return;
            }
            else if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                arr[0] = 'v';
                return;
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                arr[0] = 'v';
                return;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                arr[0] = 'v';
                return;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                arr[0] = 'v';
                return;
            }
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                arr[0] = 'v';
                return;
            }
            else if (arr[7] == arr[5] && arr[5] == arr[3])
            {
                arr[0] = 'v';
                return;
            }

            if (arr[7] != '7' && arr[8] != '8' && arr[9] != '9' &&
                arr[4] != '4' && arr[5] != '5' && arr[6] != '6' &&
                arr[1] != '1' && arr[2] != '2' && arr[3] != '3')
            {
                arr[0] = 'd';
            }
            else
            {
                arr[0] = '0';
            }
        }

        public char GetGameStatus()
        {
            return arr[0];
        }

        public void Board()
        {
            for (int i = 1; i <= 9; i++)
            {
                if (arr[i] == 'X')
                {
                    Print_X(i);
                }
                else if (arr[i] == 'O')
                {
                    Print_O(i);
                }
                else
                {
                    Print_Empty(i);
                }
            }
        }

        public bool Free_position(int pos)
        {
            if (arr[pos] != 'O' && arr[pos] != 'X')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move(int pos, char player)
        {
            arr[pos] = player;
            CheckWin();
        }

        private static void Print_X(int pos)
        {
            Print_position(in pos, out int Left, out int Top);
            Console.SetCursorPosition(Left, Top); Console.WriteLine("::::::::::::::::::::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine(":: .===.   .===.  ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::  \\ * \\  / * /  ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::   \\ * \\/ * /   ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::    > *  * <    ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::   / * /\\ * \\   ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::  / * /  \\ * \\  ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine(":: '==='    '===' ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::::::::::::::::::::");
        }
        private static void Print_O(int pos)
        {
            Print_position(in pos, out int Left, out int Top);
            Console.SetCursorPosition(Left, Top); Console.WriteLine("::::::::::::::::::::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::   .========.   ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine(":: ./   *  *   \\. ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine(":: |  *  /\\  *  | ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine(":: | *  |  |  * | ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine(":: |  *  \\/  *  | ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine(":: '\\   *  *   /' ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::   '========'   ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::::::::::::::::::::");
        }

        private static void Print_Empty(int pos)
        {
            Print_position(in pos, out int Left, out int Top);
            Console.SetCursorPosition(Left, Top); Console.WriteLine("::::::::::::::::::::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine($":: {pos}              ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::::::::::::::::::::");

        }

        private static void Print_position(in int pos, out int Left, out int Top)
        {
            int with = 18;
            int heigth = 8;

            switch (pos)
            {
                case 7:
                    Left = left + with * 0;
                    Top = top + heigth * 0;
                    break;
                case 8:
                    Left = left + with * 1;
                    Top = top + heigth * 0;
                    break;
                case 9:
                    Left = left + with * 2;
                    Top = top + heigth * 0;
                    break;
                case 4:
                    Left = left + with * 0;
                    Top = top + heigth * 1;
                    break;
                case 5:
                    Left = left + with * 1;
                    Top = top + heigth * 1;
                    break;
                case 6:
                    Left = left + with * 2;
                    Top = top + heigth * 1;
                    break;
                case 1:
                    Left = left + with * 0;
                    Top = top + heigth * 2;
                    break;
                case 2:
                    Left = left + with * 1;
                    Top = top + heigth * 2;
                    break;
                case 3:
                    Left = left + with * 2;
                    Top = top + heigth * 2;
                    break;
                default:
                    Left = 0;
                    Top = 0;
                    break;
            }
        }
    }
}
