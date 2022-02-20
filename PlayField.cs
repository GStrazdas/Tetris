﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class PlayField
    {
        public byte[,] emptyField = new byte[,]
        {
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6},
            {6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6},
        };
        public byte[,] field = new byte[21, 24];
        public byte[,] gameOver = new byte[,]
        {
            {00, 77, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 78, 00, 00},
            {00, 71, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 71, 00, 00},
            {00, 71, 00, 00, 75, 75, 00, 00, 75, 00, 00, 75, 00, 00, 00, 75, 00, 75, 75, 75, 00, 71, 00, 00},
            {00, 71, 00, 75, 00, 00, 00, 75, 00, 75, 00, 75, 75, 00, 75, 75, 00, 75, 00, 00, 00, 71, 00, 00},
            {00, 71, 00, 75, 00, 75, 00, 75, 00, 75, 00, 75, 00, 75, 00, 75, 00, 75, 75, 00, 00, 71, 00, 00},
            {00, 71, 00, 75, 00, 75, 00, 75, 75, 75, 00, 75, 00, 00, 00, 75, 00, 75, 00, 00, 00, 71, 00, 00},
            {00, 71, 00, 00, 75, 75, 00, 75, 00, 75, 00, 75, 00, 00, 00, 75, 00, 75, 75, 75, 00, 71, 00, 00},
            {00, 71, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 71, 00, 00},
            {00, 71, 00, 00, 75, 00, 00, 75, 00, 00, 00, 75, 00, 75, 75, 75, 00, 75, 75, 00, 00, 71, 00, 00},
            {00, 71, 00, 75, 00, 75, 00, 75, 00, 00, 00, 75, 00, 75, 00, 00, 00, 75, 00, 75, 00, 71, 00, 00},
            {00, 71, 00, 75, 00, 75, 00, 00, 75, 00, 75, 00, 00, 75, 75, 00, 00, 75, 75, 75, 00, 71, 00, 00},
            {00, 71, 00, 75, 00, 75, 00, 00, 75, 00, 75, 00, 00, 75, 00, 00, 00, 75, 75, 00, 00, 71, 00, 00},
            {00, 71, 00, 00, 75, 00, 00, 00, 00, 75, 00, 00, 00, 75, 75, 75, 00, 75, 00, 75, 00, 71, 00, 00},
            {00, 71, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 71, 00, 00},
            {00, 72, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 74, 00, 00},
        };
        public void DrawField(byte[,] nextFigure)
        {
            byte[,] nextFigureType = nextFigure;
            Console.WriteLine();
            for(int i = 0; i < 21; i++)
            {
                for(int j = 0; j < 24; j++)
                {
                    DisplayChar(field[i, j]);
                }
                switch(i)
                {
                    case 0:
                        Console.Write("    Next:");
                        break;
                    case 1:
                        Console.Write("    ");
                        for (int j = 0; j < 8; j++)
                        {
                            DisplayChar(nextFigureType[0, j]);
                        }
                        break;
                    case 2:
                        Console.Write("    ");
                        for (int j = 0; j < 8; j++)
                        {
                            DisplayChar(nextFigureType[1, j]);
                        }
                        break;
                    case 3:
                        Console.Write("    ");
                        for (int j = 0; j < 8; j++)
                        {
                            DisplayChar(nextFigureType[2, j]);
                        }
                        break;
                    case 4:
                        Console.Write("    ");
                        for (int j = 0; j < 8; j++)
                        {
                            DisplayChar(nextFigureType[3, j]);
                        }
                        break;
                }
                Console.WriteLine();
            }
        }
        public void DisplayChar(int number)
        {
            int charNumber = number;
            switch (charNumber % 10)
            {
                case 0:
                    Console.Write(" ");
                    break;
                case 1:
                    Console.Write("║");
                    break;
                case 2:
                    Console.Write("╚");
                    break;
                case 3:
                    Console.Write("═");
                    break;
                case 4:
                    Console.Write("╝");
                    break;
                case 5:
                    ChangeColor(charNumber);
                    Console.Write("▓");
                    Console.ResetColor();
                    break;
                case 6:
                    Console.Write("░");
                    break;
                case 7:
                    Console.Write("╔");
                    break;
                case 8:
                    Console.Write("╗");
                    break;
            }
        }
        public void ChangeColor(int number)
        {
            int colorNumber = number / 10;
            switch (colorNumber)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
        public bool CheckLine(int lineNumber)
        {
            int line = lineNumber;
            for (int i = 2; i < 22; i++)
            {
                if (field[line, i] == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void RemoveFullLines()
        {
            for(int i = 19; i > 0; i--)
            {
                if (CheckLine(i))
                {
                    RemoveLine(i);
                    i++;
                }
            }
        }
        public void RemoveLine(int lineNumber)
        {
            int line = lineNumber;
            for (int i = line; i > 0; i--)
            {
                for (int j = 2; j < 22; j++)
                {
                    field[i, j] = field[i - 1, j];
                }
            }
        }
    }
}
