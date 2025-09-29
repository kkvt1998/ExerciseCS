using System;

class Program
{
    //create a class rectangle
    class Rectangle
    {
        public double width;
        public double height;
        //phuong thuc khoi tao khong tham so
        public Rectangle()
        {

        }
        //phuong thuc khoi tao co tham so
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        //phuong thuc tinh dien tich
        public double GetArea()
        {
            return this.width * this.height;
        }
        //phuong thuc tinh chu vi
        public double GetPerimeter()
        {
            return (this.width + this.height) * 2;
        }
        //Phuong thuc hien thi
        public string Display()
        {
            return "Rectangle : { width = " + this.width + ", height = " + this.height +" }";
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Program: Class Rectangle");
       //Nhap vao gia tri cua doi tuong
        Console.WriteLine("Nhap vao chieu dai hinh chu nhat: ");
        double width = Double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap vao chieu rong hinh chu nhat: ");
        double height = Double.Parse(Console.ReadLine());
        //Khoi tao doi tuong hcn
        Rectangle _rectangle = new Rectangle(width, height);
        //Hien thi thong tin
        //Hien thi hinh chu nhat
        Console.WriteLine("Hinh chu nhat " + _rectangle.Display());
        //Tinh dien tich
        Console.WriteLine("Dien tich hinh chu nhat " + _rectangle.GetArea());
        //Tinh chu vi
        Console.WriteLine("Chu vi hinh chu nhat " + _rectangle.GetPerimeter());
    }
}
