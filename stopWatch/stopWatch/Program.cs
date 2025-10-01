using System;

namespace stopWatch
{
    class Program
    {
        //Thuat toan sap xep chon cho 100000 so
        public static void selectionSort(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[j] < x[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if(minIndex != i)
                {
                    int temp = x[minIndex];
                    x[minIndex] = x[i];
                    x[i] = temp; 
                }
            }
        }
        //Creation the class stopWatch
        public class StopWatch
        {
            private long startTime;
            public long StatTime
            {
                get { return startTime; }
            }
            private long endTime;
            public long EndTime
            {
                get { return endTime; }
            }
            //Constructor startTime non values
            public StopWatch()
            {
                //Return time now 
                this.startTime = DateTime.Now.Ticks;
            }
            public void Start()
            {
                this.startTime = DateTime.Now.Ticks;
            }
            public void Stop()
            {
                this.endTime = DateTime.Now.Ticks;
            }
            public long GetElapsedTime()
            {
                return this.endTime - this.startTime;
            }

        }
        public static void Main(string[] args) 
        {
            Console.WriteLine("Program: Stop Watch");
            //Khoi tao doi tuong stopWatch
            StopWatch stop_watch = new StopWatch();
            //Khoi tao 1 mang co 100000 so bat ki
            int[] array = new int[100000];
            //tao ra cac gia tri ngau nhien
            Random random = new Random();
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = random.Next();
            }
            //Start Watch
            Console.WriteLine("Bat dau sap xep");
            stop_watch.Start();
            //Thuc hien thuat toan sap xep
            selectionSort(array);
            //Stop Watch
            stop_watch.Stop();
            Console.WriteLine("Ket thuc sap xep");
            Console.WriteLine("Thoi gian bat dau " + $"{stop_watch.StatTime}");
            Console.WriteLine("Thoi gian ket thuc " + $"{stop_watch.EndTime}");
            Console.WriteLine("Thoi gian thuc thi " + $"{stop_watch.GetElapsedTime()/10000000} s");
        }
    }
}