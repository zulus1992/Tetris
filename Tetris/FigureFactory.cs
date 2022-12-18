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
        public static int[,] Create(int figureIndex)
        {
            switch (figureIndex)
            {
                case 1: return new int[,] { { 0, 1, 2, 3 }, { 1, 1, 1, 1 } }; break;
                case 2: return new int[,] { { 0, 1, 2, 2 }, { 1, 1, 1, 0 } }; break;
                case 3: return new int[,] { { 0, 1, 2, 2 }, { 1, 1, 1, 2 } }; break;
                case 4: return new int[,] { { 1, 2, 2, 2 }, { 1, 0, 1, 2 } }; break;
                case 5: return new int[,] { { 1, 1, 2, 2 }, { 2, 1, 1, 0 } }; break;
                case 6: return new int[,] { { 1, 1, 2, 2 }, { 0, 1, 1, 2 } }; break; 
                case 7: return new int[,] { { 0, 1, 0, 1 }, { 1, 1, 2, 2 } }; break;
                default:
                    throw new Exception("Wrong figureIndex");
            }
        }
    }
}
