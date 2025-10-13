using System;

class Game
{
    //kich thuoc ban do game
    const int GameWidth = 50;
    const int GameHeight = 25;
    //tao mang 2D de ve ban do
    char[,] map = new char[GameWidth, GameHeight];
    // vi tri cua nguoi choi
    int playerX = 5;
    int playerY = 5;
    // vi tri chuong ngai vat
    int spaceSize = 6;
    int pipeSpacing = 15;
    List <(int pipeX, int blank)> pipes = new List <(int, int)>();
    Random rand = new Random();
    //thuoc tinh Game
    bool isGameOver = false;
    bool isGameExit = false;
    int Score = 0;
    //Ham set up Game
    public void SetUpGame()
    {
        //Doi ten tieu de cua so Console
        Console.Title = "My Game - Module 1 - 2025";
        //Cai dat kich thuoc cua so de hien thi ban do
        Console.SetWindowSize(GameWidth, GameHeight + 1);
        Console.CursorVisible = false;// Hide Cursor
        //Ve vien xung quanh ban do
        // Tạo 3 ống ban đầu
        for (int i = 0; i < 3; i++)
        {
            // Tạp ra 3 ống cách đều nhau theo chiều Width
            int pipeX = GameWidth + i * pipeSpacing;
            // Vị trí ngẫu nhiên của khoảng trống trong ống;
            int blank = rand.Next(2, GameHeight - spaceSize);
            pipes.Add((pipeX, blank));
        }
        for (int i = 0; i < GameWidth; i++)
        {
            for (int j = 1; j < GameHeight; j++)
            {
                if (i == 0 || j == 1 || i == GameWidth - 1 || j == GameHeight - 1)
                {
                    map[i, j] = '#';
                }
              
                else
                {
                    map[i, j] = ' ';
                }
            }
        }
    }
    //Ham thuc thi viec ve cac doi tuong trong ban do
    public void DrawGame()
    {
        for (int i = 0; i < GameWidth; i++)
        {
            for (int j = 0; j < GameHeight; j++)
            {
                Console.SetCursorPosition(i, j);
                if(i == 0 && j == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Score: " + Score);
                    continue;
                }
                if (map[i, j] == '#')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if( i == playerX && j == playerY)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write('@');
                }
                
                Console.Write(map[i, j]);
            }
        }
        foreach (var pipe in pipes)
        {
            for (int j = 2; j < GameHeight - 1; j++)
            {
                // chỉ vẽ ống ngoài khoảng trống
                if (j < pipe.blank || j > pipe.blank + spaceSize)
                {
                    if (pipe.pipeX > 0 && pipe.pipeX < GameWidth)
                    {
                        Console.SetCursorPosition(pipe.pipeX, j);
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.Write("|");
                    }
                }
            }
        }
        Console.ResetColor();
    }
    
    //Ham thuc hien viec vong lap Game
    public void GameLoop()
    {
        while(!isGameExit == true) 
        {
            while (!isGameOver)
            {
                playerY++;
                //Kiểm tra xem có nhấn phím hay không
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    handleInput(key);
                }
                if (playerY == GameHeight - 1)
                {
                    isGameOver = true;
                }
                // Dịch trái vị trí các ống theo phương width
                for (int i = 0; i < pipes.Count; i++)
                {
                    pipes[i] = (pipes[i].pipeX - 1, pipes[i].blank);

                    if (pipes[i].pipeX == playerX)
                    {
                        // Kiểm tra va chạm với ống
                        if (playerY < pipes[i].blank || playerY > pipes[i].blank + spaceSize)
                        {
                            isGameOver = true;
                        }
                        else
                        {
                            Score++;
                        }
                    }
                }

                // Nếu ống đầu tiên ra khỏi màn hình -> thêm ống mới
                if (pipes[0].pipeX < -1)
                {
                    pipes.RemoveAt(0);
                    pipes.Add((GameWidth, rand.Next(2, GameHeight - spaceSize)));
                }
                DrawGame();


                Thread.Sleep(100);
            }
            Console.Clear();
            Console.WriteLine("End Game");
            Console.WriteLine("Your score: " + Score);
            Console.WriteLine("Press Enter to Restart Game or ESC to Exit");
            RestartGame();
            Thread.Sleep(100);

        }
    }
    //Ham thuc thi lenh tu ban phim
    public void handleInput(ConsoleKeyInfo key)
    {
        int newY = playerY;
        if (key.Key == ConsoleKey.UpArrow)
        {
            newY = newY - 2;
        }
        
        // Kiểm tra va chạm (chỉ cho phép đi trong phạm vi "khoảng trống")
        if(newY > 0)
        {
            playerY = newY;
        }
    }
    // Hàm Restart Game
    public void RestartGame()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if(key.Key == ConsoleKey.Enter)
            {
                // Reset các thuộc tính của trò chơi
                playerX = 5;
                playerY = 5;
                pipes.Clear();
                Score = 0;
                isGameOver = false;
                SetUpGame();
                Console.Clear();
                GameLoop();
            }
            else if(key.Key == ConsoleKey.Escape)
            {
                isGameExit = true;
            }
        }
    }
    //Ham thuc thi tro choi
    public void RunGame()
    {
        SetUpGame();
        GameLoop();
    }

}
class Program
{
    public static void Main(string[] args)
    {
        //Tao doi tuong Game
        Game game = new Game();
        //Goi ham thuc thi tro choi
        game.RunGame();
    }
}
