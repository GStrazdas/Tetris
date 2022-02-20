using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Figure
    {
        public byte figureXCoord;
        public byte figureYCoord;
        public string figureName = "";
        public byte [,] figureTypeOld = new byte[4, 8];
        public byte[,] figureT = new byte[,]
        {
                {0, 0, 0, 0, 0, 0, 0, 0},
                {5, 5, 5, 5, 5, 5, 0, 0},
                {0, 0, 5, 5, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0}
        };
        public byte[,] figureL1 = new byte[,]
        {
                {0, 0, 0, 0, 0, 0, 0, 0},
                {5, 5, 5, 5, 5, 5, 0, 0},
                {0, 0, 0, 0, 5, 5, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0}
        };
        public byte[,] figureL2 = new byte[,]
        {
                {0, 0, 0, 0, 0, 0, 0, 0},
                {5, 5, 5, 5, 5, 5, 0, 0},
                {5, 5, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0}
        };
        public byte[,] figureType = new byte[4, 8];
        public void RandomFigure()
        {
            Random rnd = new Random();
            int randInt = rnd.Next(0, 2);
            switch (randInt)
            {
                case 0:
                    Array.Copy(figureT, figureType, 32);
                    figureName = "figureT";
                    break;
                case 1:
                    Array.Copy(figureL1, figureType, 32);
                    figureName = "figureL1";
                    break;
                case 2:
                    Array.Copy(figureL2, figureType, 32);
                    figureName = "figureL2";
                    break;
            }
        }
        public bool DrawFigure(PlayField playField)
        {
            PlayField field = playField;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (figureType[i, j] == 5)
                    {
                        field.field[figureYCoord + i - 1, figureXCoord + j - 2] = figureType[i, j];
                    }
                }
            }
            return true;
        }
        public void ClearFigure(PlayField playField)
        {
            PlayField field = playField;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (figureType[i, j] == 5)
                    {
                        field.field[figureYCoord + i - 1, figureXCoord + j - 2] = 0;
                    }
                }
            }
        }
        public bool RotateFigure(PlayField playField)
        {
            PlayField field = playField;
            ClearFigure(field);
            Array.Copy(figureType, figureTypeOld, 32);
            figureType[0, 0] = figureTypeOld[2, 0];
            figureType[0, 1] = figureTypeOld[2, 1];
            figureType[0, 2] = figureTypeOld[1, 0];
            figureType[0, 3] = figureTypeOld[1, 1];
            figureType[0, 4] = figureTypeOld[0, 0];
            figureType[0, 5] = figureTypeOld[0, 1];
            figureType[1, 0] = figureTypeOld[2, 2];
            figureType[1, 1] = figureTypeOld[2, 3];
            figureType[2, 0] = figureTypeOld[2, 4];
            figureType[2, 1] = figureTypeOld[2, 5];
            figureType[2, 2] = figureTypeOld[1, 4];
            figureType[2, 3] = figureTypeOld[1, 5];
            figureType[2, 4] = figureTypeOld[0, 4];
            figureType[2, 5] = figureTypeOld[0, 5];
            figureType[1, 4] = figureTypeOld[0, 2];
            figureType[1, 5] = figureTypeOld[0, 3];
            if (!CheckSpace(field))
            {
                Array.Copy(figureTypeOld, figureType, 32);
                Console.Beep(500, 300);
                return false;
            }
            return true;
        }
        public bool CheckSpace(PlayField playField)
        {
            PlayField field = playField;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (figureType[i, j] == 5 && field.field[figureYCoord + i - 1, figureXCoord + j - 2] != 0)
                    {
                        Console.Beep(500, 300);
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
