using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Tetris
{
    internal class GameStream
    {
        public bool figureOnField = false;
        public bool updateField = false;
        Figure figure = new Figure();
        PlayField playField = new PlayField();
        ConsoleKeyInfo cki;
        public void Run()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 500;

            Console.Clear();
            playField.DrawField();
            Console.WriteLine();
            Console.WriteLine("Press the Enter key to start or the Escape (Esc) key to exit...");
            Console.ReadKey();
            aTimer.Enabled = true;
            aTimer.Start();

            do
            {
                if (Console.KeyAvailable)
                {
                    aTimer.Stop();
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                    if (cki.Key == ConsoleKey.LeftArrow)
                    {
                        figure.ClearFigure(playField);
                        figure.figureXCoord -= 2;
                        if (!figure.CheckSpace(playField))
                        {
                            figure.figureXCoord += 2;
                        }
                        figure.DrawFigure(playField);
                    }
                    if (cki.Key == ConsoleKey.RightArrow)
                    {
                        figure.ClearFigure(playField);
                        figure.figureXCoord += 2;
                        if (!figure.CheckSpace(playField))
                        {
                            figure.figureXCoord -= 2;
                        }
                        figure.DrawFigure(playField);
                    }
                    if (cki.Key == ConsoleKey.DownArrow)
                    {
                        figure.ClearFigure(playField);
                        figure.figureYCoord++;
                        if (!figure.CheckSpace(playField))
                        {
                            figure.figureYCoord--;
                            figure.DrawFigure(playField);
                            figureOnField = false;
                        }
                        figure.DrawFigure(playField);
                    }
                    if (cki.Key == ConsoleKey.UpArrow || cki.Key == ConsoleKey.Spacebar)
                    {
                        if (figure.RotateFigure(playField))
                        {
                            figure.DrawFigure(playField);
                        }
                    }
                    updateField = true;
                }
                if (updateField)
                {
                    if (!figureOnField)
                    {
                        playField.RemoveFullLines();
                        figureOnField = true;
                        figure.figureYCoord = 1;
                        figure.figureXCoord = 12;
                        figure.RandomFigure();
                        if (!figure.CheckSpace(playField))
                        {
                            Console.WriteLine("GameOver");
                            break;
                        }
                        figure.DrawFigure(playField);
                    }
                    Console.Clear();
                    playField.DrawField();
                    Console.WriteLine();
                    Console.WriteLine("Press the Escape (Esc) key to exit...");
                    updateField = false;
                    aTimer.Start();
                }
            }
            while (true);
        }

        private void OnTimedEvent(object? sender, ElapsedEventArgs e)
        {
            figure.ClearFigure(playField);
            figure.figureYCoord++;
            if (!figure.CheckSpace(playField))
            {
                figure.figureYCoord--;
                figure.DrawFigure(playField);
                figureOnField = false;
                updateField = true;
            }
            else
            {
                figure.DrawFigure(playField);
                updateField = true;
            }
        }
    }
}
