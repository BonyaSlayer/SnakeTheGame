using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point(1, 3, '*');                   
            
            //Point p2 = new Point(4, 5, '#');
            
            //p1.Draw();
            //p2.Draw();

            HorizontalLine line = new HorizontalLine(2,6,1, '-');


            VerticalLine line2 = new VerticalLine(1, 5, 1, '|');
            
            line.Draw();
            line2.Draw();


            Console.ReadKey();
        }
        
    }
}
