using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class HorizontalLine
    {
        List<Point> pList;
        /// <summary>
        /// Конструктор Горизонтальных линий на оси х/у
        /// </summary>
        /// <param name="xLeft">Начало на оси х</param>
        /// <param name="xRight">Конец на оси х</param>
        /// <param name="y">Начальная точка на оси y</param>
        /// <param name="sym">Символ</param>
        public HorizontalLine(int xLeft, int xRight, int y, char sym) 
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
            
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
