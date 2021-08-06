using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CresticiNolici_CSharp2
{
    public class CLI
    {
        static int left = 0;
        static int top = 3;
        public static void PrintEmpti(int position)
        {
            Print_position(in position, out int Left, out int Top);
            Console.SetCursorPosition(Left, Top); Console.WriteLine("::::::::::::::::::::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine($":: {position}              ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::::::::::::::::::::");
        }
        public static void PrintEnd()
        {
            switch (Board.Status)
            {
                case StatusType.Draw:
                    PrintDraw("Draw");
                    break;
                case StatusType.WinO:
                    PrintWin("Win O");
                    break;
                case StatusType.WinX:
                    PrintWin("Win X");
                    break;
            }
        }

        private static void Print(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        private static void PrintWin(string message)
        {
            Print(message, ConsoleColor.Red);
        }
        private static void PrintDraw(string message)
        {
            Print(message, ConsoleColor.Gray);
        }
        private static void PrintInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(message);
            Console.ResetColor();
        }
        private static void Print_X(int position)
        {
            Print_position(in position, out int Left, out int Top);
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
        private static void Print_O(int position)
        {
            Print_position(in position, out int Left, out int Top);
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

        private static void Print_Empty(int position)
        {
            Print_position(in position, out int Left, out int Top);
            Console.SetCursorPosition(Left, Top); Console.WriteLine("::::::::::::::::::::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine($":: {position}              ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::                ::");
            Console.SetCursorPosition(Left, ++Top); Console.WriteLine("::::::::::::::::::::");

        }

        private static void Print_position(in int position, out int Left, out int Top)
        {
            int with = 18;
            int heigth = 8;

            switch (position)
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
