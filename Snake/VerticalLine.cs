using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class VerticalLine : Figure
    {
       
        /// <summary>
        /// Консруктор Вертикальных линий на осях x/y
        /// </summary>
        /// <param name="yUp">Начало по оси y</param>
        /// <param name="yDown">Конец по оси y</param>
        /// <param name="x">Точка на оси х</param>
        /// <param name="sym">Символ</param>
        public VerticalLine( int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int i =yUp; i <=yDown; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }

        }

        
    }
}
