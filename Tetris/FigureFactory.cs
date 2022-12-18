using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class FigureFactory
    {
        private static List<int[,]> Figures=new List<int[,]>();

        static FigureFactory()
        {
            Figures.Add(new int[,] { { 0, 1, 2, 3 }, { 1, 1, 1, 1 } });
            Figures.Add(new int[,] { { 0, 1, 2, 2 }, { 1, 1, 1, 0 } });
            Figures.Add(new int[,] { { 0, 1, 2, 2 }, { 1, 1, 1, 2 } });
            Figures.Add(new int[,] { { 1, 2, 2, 2 }, { 1, 0, 1, 2 } });
            Figures.Add(new int[,] { { 1, 1, 2, 2 }, { 2, 1, 1, 0 } });
            Figures.Add(new int[,] { { 1, 1, 2, 2 }, { 0, 1, 1, 2 } });
            Figures.Add(new int[,] { { 0, 1, 0, 1 }, { 1, 1, 2, 2 } });
        }

        public static int[,] Get()
        {
            Random rand = new Random();
            var randValue = rand.Next(0, Figures.Count()-1);
            return (int[,])Figures[randValue].Clone();
        }

        public static void Add(int[,] figure)
        {
            Figures.Add(figure);
        }

    }
}
