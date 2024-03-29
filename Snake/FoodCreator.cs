﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidht = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood(Snake snake)
        {
            Point food;

            do
            {
                int x = random.Next(2, mapWidht - 2);
                int y = random.Next(2, mapHeight - 2);
                food = new Point(x, y, sym);
            } while (snake.isCollision(food));
            return food;
        }
    }
}
