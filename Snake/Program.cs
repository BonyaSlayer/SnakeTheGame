using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');                   
            
            Point p2 = new Point(4, 5, '#');
            
            p1.Draw();
            p2.Draw();
            


            Console.ReadKey();
        }
        
    }
}
