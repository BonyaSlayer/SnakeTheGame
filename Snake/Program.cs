using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Walls walls = new Walls(80, 25);
            walls.Draw();
            

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            //Отрисовка еды
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood(snake);
            food.Draw();

            Console.CursorVisible = false;
            while (true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail()) 
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood(snake);
                    food.Draw();
                    snake.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                    
                }
            }
            WriteGameOver();
            Console.ReadKey();

        }

        static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset++);
            yOffset++;
            WriteText("Автор: Богдан Остапенко", xOffset + 2, yOffset++);
            WriteText("      Press any Key", xOffset + 1, yOffset++);
            WriteText("============================", xOffset, yOffset++);
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

    }
}
