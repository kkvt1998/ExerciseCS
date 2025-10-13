using System;
using System.Threading;

class Program
{
    static void Main()
    {
        double goc = 0;

        // Điều chỉnh vị trí ban đầu (offset)
        int offsetY = 10;  // dịch chuyển theo chiều dọc
        int offsetX = 50;  // dịch chuyển theo chiều ngang

        while (true)
        {
            // Dao động theo sin
            double y = Math.Sin(goc) * 5; // biên độ 5
            int posY = (int)(y + offsetY);

            Console.Clear();

            for (int i = 0; i < 20; i++)
            {
                if (i == posY)
                    Console.WriteLine(new string(' ', offsetX) + "O"); // thêm khoảng trắng để dịch ngang
                else
                    Console.WriteLine();
            }

            goc += 0.2;
            Thread.Sleep(100);
        }
    }
}