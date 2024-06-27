namespace ConsoleWork.SubApps
{
    public class Snake
    {
        static int width = 40;
        static int height = 20;
        static int score = 0;
        static int foodX;
        static int foodY;
        static List<(int x, int y)> snake = new List<(int x, int y)> { (20, 10) };
        static (int x, int y) direction = (1, 0); // Moving right initially
        static Random random = new Random();

        public static void Run()
        {
            while (true)
            {
                ResetGame();
                Console.CursorVisible = false;
                SpawnFood();
                while (true)
                {
                    Draw();
                    Input();
                    Logic();
                    Thread.Sleep(100); // Adjust speed of the snake

                    if (IsGameOver())
                    {
                        break;
                    }
                }
                GameOver();
            }
        }

        static void Draw()
        {
            Console.Clear();
            DrawRow(0);
            Console.WriteLine($"Score: {score}");
        }

        static void DrawRow(int y)
        {
            if (y >= height)
                return;

            DrawColumn(y, 0);
            Console.WriteLine();
            DrawRow(y + 1);
        }

        static void DrawColumn(int y, int x)
        {
            if (x >= width)
                return;

            if (snake.Contains((x, y)))
            {
                Console.Write("O"); // Snake body
            }
            else if (x == foodX && y == foodY)
            {
                Console.Write("X"); // Food
            }
            else
            {
                Console.Write(" "); // Empty space
            }

            DrawColumn(y, x + 1);
        }

        // static void Draw()
        // {
        //     Console.Clear();
        //     for (int y = 0; y < height; y++)
        //     {
        //         for (int x = 0; x < width; x++)
        //         {
        //             if (snake.Contains((x, y)))
        //             {
        //                 Console.Write("O"); // Snake body
        //             }
        //             else if (x == foodX && y == foodY)
        //             {
        //                 Console.Write("X"); // Food
        //             }
        //             else
        //             {
        //                 Console.Write(" "); // Empty space
        //             }
        //         }
        //         Console.WriteLine();
        //     }
        //     Console.WriteLine($"Score: {score}");
        // }

        static void Input()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        direction = (0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        direction = (0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        direction = (-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        direction = (1, 0);
                        break;
                }
            }
        }

        static void Logic()
        {
            var (headX, headY) = snake.First();
            var (dirX, dirY) = direction;
            var newHead = (x: headX + dirX, y: headY + dirY);

            if (
                newHead.x < 0
                || newHead.x >= width
                || newHead.y < 0
                || newHead.y >= height
                || snake.Contains(newHead)
            )
            {
                return;
            }

            if (newHead.x == foodX && newHead.y == foodY)
            {
                score++;
                SpawnFood();
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }

            snake.Insert(0, newHead);
        }

        static bool IsGameOver()
        {
            var (headX, headY) = snake.First();
            return headX < 0 || headX >= width || headY < 0 || headY >= height || snake.Skip(1).Contains((headX, headY));
        }

        static void SpawnFood()
        {
            foodX = random.Next(0, width);
            foodY = random.Next(0, height);
        }

        static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game Over!");
            Console.WriteLine($"Final Score: {score}");
            Console.WriteLine("Press any key to restart...");

            Console.ReadKey(true); // Wait for a key press
        }

        static void ResetGame()
        {
            score = 0;
            snake = new List<(int x, int y)> { (20, 10) };
            direction = (1, 0); // Reset direction to moving right initially
        }
    }
}