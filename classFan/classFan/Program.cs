using System;
using System.Runtime.CompilerServices;

namespace classFan
{
    class Program
    {
        public class Fan
        {
            //khai bao thuoc tinh 
            const int SLOW = 1;
            const int MEDIUM = 2;
            const int FAST = 3;
            //
            private int speed = SLOW;
            public int Speed
            {
                get { return speed; }
                set { speed = value; }
            }
            //
            private bool on = false;
            public bool On
            {
                get { return on; }
                set { on = value; }
            }
            private double radius = 5;
            public double Radius
            {
                get { return radius; }
                set { radius = value; }
            }
            private string color = "blue";
            public string Color
            {
                get { return color; }
                set { color = value; }
            }

            public Fan()
            {

            }
            public string ToString(bool on, int speed, string color, double radius)
            {
                if (on)
                {
                    return "Fan is on : Speed " + speed + ", color: " + color + ", radius: " + radius;
                }
                else
                {
                    return "Fan is off : color: " + color + ", radius: " + radius;

                }
            }
                

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Program: Class Fan");
            //Tao 2 doi tuong Fan
            Fan fan_1 = new Fan();
            Console.WriteLine(fan_1.ToString(true, 10, "yellow", 10));
            Fan fan_2 = new Fan();
            Console.WriteLine(fan_2.ToString(false, 5, "blue", 5));
        }
    }
}
