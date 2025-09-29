using System;

namespace classAnimal
{
    class Program
    {
        //Tao mot lop truu tuong
        public abstract class Animal
        {
            protected string Weight { get; set; }
            protected string Height { get; set; }

            public Animal(string Weight, string Height)
            {
                this.Weight = Weight;
                this.Height = Height;
            }
            public abstract void PrintInfo();
            
        }
        //tao class con ke thua lop animal
        class Cat : Animal
        {
            //private
            private string name {  get; set; }
            public Cat(string weight, string height, string name) : base(weight, height) 
            {
                this.name = name;
            }
            public override void PrintInfo() 
            {
                Console.WriteLine("Weight :" + this.Weight);
                Console.WriteLine("Height :" + this.Height);
                Console.WriteLine("Name :" + this.name);
            }
        }
        public static void Main(string[] args) {
            //khoi tai doi tuong Cat
            Cat _newCat = new Cat("20kg", "1.5", "Kitty");
            _newCat.PrintInfo();
        }
    }
}