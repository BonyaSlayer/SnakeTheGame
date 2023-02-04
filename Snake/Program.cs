using System;
using System.Collections.Generic;

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

            List<int> numlist = new List<int>();
            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2);

            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];
            
            foreach(int i in numlist)
            {
              Console.WriteLine(i);
            }

            numlist.RemoveAt(0);

            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);



            


            Console.ReadKey();
        }
        
    }
}
