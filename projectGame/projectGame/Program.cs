using System;
using System.Threading;

public class Game
{
    // Kích thước bản đồ
    const int MapWidth = 50;
    const int MapHeight = 25;

    // Mảng 2D (bản đồ)
    char[,] map = new char[MapHeight, MapWidth];

    //Tọa độ và ký tự người chơi
    int playerX = 5;
    int playerY = 5;
    char playerChar = '@';

    public void Run()
    {
        SetupGame();
        GameLoop();
    }

    void SetupGame()
    {
        Console.Title = "CLI C# Game - Dùng WASD/Mũi tên để di chuyển, ESC để thoát";
        // Cài đặt kích thước cửa sổ để hiển thị bản đồ
        Console.SetWindowSize(MapWidth, MapHeight + 1);
        Console.CursorVisible = false;

        // Điền bản đồ (Tạo tường bao quanh)
        for (int y = 0; y < MapHeight; y++)
        {
            for (int x = 0; x < MapWidth; x++)
            {
                if (y == 0 || y == MapHeight - 1 || x == 0 || x == MapWidth - 1)
                {
                    map[y, x] = '#'; // Tường
                }
                else
                {
                    map[y, x] = ' '; // Khoảng trống
                }
            }
        }
    }

    void DrawGame()
    {
        // 1. Vẽ bản đồ và người chơi
        for (int y = 0; y < MapHeight; y++)
        {
            for (int x = 0; x < MapWidth; x++)
            {
                // Đặt con trỏ đến vị trí x, y
                Console.SetCursorPosition(x, y);

                // Kiểm tra xem có phải vị trí người chơi không
                if (x == playerX && y == playerY)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(playerChar);
                }
                else
                {
                    // Vẽ các phần tử bản đồ
                    if (map[y, x] == '#')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(map[y, x]);
                }
            }
        }
        Console.ResetColor();
    }
    void daodong(int a, int b)
    {
        double goc = 0;
        while (true)
        {
            // Tạo giá trị y dao động theo hàm sin
            double y = Math.Sin(goc) * 5; // nhân 5 để biên độ lớn hơn

            //Console.Clear();
            int pos = (int)(y + b); // +10 để tránh âm, đưa vào vùng hiển thị
            
            goc += 0.2; // tăng gó
        }
    }
    void GameLoop()
    {
        while (true)
        {
            //Xử lý đầu vào
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                HandleInput(key);
            }
            DrawGame();
            daodong(playerY);
            //Vẽ lại màn hình
            

            // Điều chỉnh tốc độ (50ms tương đương khoảng 20 FPS)
            Thread.Sleep(0);
        }
    }

    void HandleInput(ConsoleKeyInfo key)
    {
        int newX = playerX;
        int newY = playerY;

        switch (key.Key)
        {
            case ConsoleKey.UpArrow:
            case ConsoleKey.W:
                newY--;
                break;
            case ConsoleKey.DownArrow:
            case ConsoleKey.S:
                newY++;
                break;
            case ConsoleKey.LeftArrow:
            case ConsoleKey.A:
                newX--;
                break;
            case ConsoleKey.RightArrow:
            case ConsoleKey.D:
                newX++;
                break;
            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;
        }


        // Kiểm tra va chạm (chỉ cho phép đi trong phạm vi "khoảng trống")
        if (newX > 0 && newX < MapWidth - 1 && newY > 0 && newY < MapHeight - 1)
        {
            playerX = newX;
            playerY = newY;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            new Game().Run();
        }
    }
}