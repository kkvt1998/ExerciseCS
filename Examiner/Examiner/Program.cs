using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
class Program{
    //input method style Double
    public static double in_put_double()
    {
        string x = "";
        double result = 0;
        bool check = false;
        while (!check)
        {
            x = Console.ReadLine();
            if (double.TryParse(x, out result))
            {
                check = true;
            }
            else
            {
                Console.WriteLine("Input invalid, please re-enter!");
            }
        }
        return result;
    }
    //Input method style INT
    public static int in_put_int()
    {
        string x = "";
        int result = 0;
        bool check = false;
        while (!check)
        {
            x = Console.ReadLine();
            if (int.TryParse(x, out result))
            {
                check = true;
            }
            else
            {
                Console.WriteLine("Input invalid, please re-enter!");
            }
        }
        return result;
    }
    
    //Exercise 1
    public static void Diemso()
    {
        Console.WriteLine("Program: Student Scores ");
        bool access = false;
        while (!access)
        {
            Console.WriteLine("Enter the scores of student: ");
            double diem = in_put_double();
        
            if(0 <= diem && diem <= 10)
            {
                if (diem < 5)
                {
                    Console.WriteLine("Truợt");
                }
                else if (diem <= 6.9)
                {
                    Console.WriteLine("Trung Bình");
                }
                else if (diem <= 8.4)
                {
                    Console.WriteLine("Khá");
                }
                else
                {
                    Console.WriteLine("Giỏi");
                }
                Console.WriteLine("Do you want to continue (Y/N) ");
                string x = Console.ReadLine();
                if (x == "N" || x == "n")
                {
                    access = true;
                }
            }
            else
            {
                Console.WriteLine("The values is out of range 0 - 10, please re-enter!");
            }
            
        }
        
    }
    //Exercise 2
    public static void NhapDiemSo()
    {
        Console.WriteLine("Program: Nhap diem so sinh vien");
        Console.WriteLine("So diem so cua sinh vien can nhap:");
        int soMonHoc = 0 ;
        bool access = false;
        while (!access) {
            soMonHoc = in_put_int();
            if (soMonHoc > 0) { 
                access = true;
            }
            else
            {
                Console.WriteLine("Nhap sai! Vui long nhap lai!");
            }
        }
        //Tao mang chua diem so sinh vien
        int[] diemSV = new int[soMonHoc];
        Console.WriteLine("Nhap diem cua sinh vien");
        for (int i = 0; i < diemSV.Length; i++)
        {
            bool checkScore = false;
            while (!checkScore)
            {
                diemSV[i] = in_put_int ();
                if (0 <= diemSV[i] && diemSV[i] <= 10)
                {
                    checkScore = true;
                }
                else
                {
                    Console.WriteLine("Diem khong hop le, vui long nhap lai!");
                }
            }
        }
        //Tinh diem trung binh
        double sum = 0;
        int maxScore = diemSV[0];
        int minScore = diemSV[0];
        for (int i = 0; i < diemSV.Length; i++)
        {
            sum = sum + diemSV[i];
            if (diemSV[i] > maxScore) { 
                maxScore = diemSV[i];
            }
            if (diemSV[i] < minScore)
            {
                minScore = diemSV[i];
            }
        }
        Console.WriteLine("Diem trung binh : " + (sum / soMonHoc));
        Console.WriteLine("Diem cao nhat : " + maxScore);
        Console.WriteLine("Diem thap nhat : " + minScore);
    }
    //Exercise 3:
    
    public static void ListSV()
    {
        Console.WriteLine("Program: Danh sach sinh vien");
        //Tao list sv
        List <string> listSV = new List <string> ();
        bool access = false;
        while (!access)
        {
            Console.WriteLine("Nhap ten Sinh vien: ");
            string nameSV = Console.ReadLine();
            if (nameSV == "")
            {
                Console.WriteLine("Vui long nhap ten");

            }
            else if (nameSV == "end")
            {
                access = true;
            }
            else
            {
                //them sinh vien vao list
                listSV.Add(nameSV);
            }
        }
        int maxLength = 0;
        string maxName = "";
        Console.WriteLine("Danh sach sinh vien: ");

        for (int i = 0; i < listSV.Count; i++) 
        {
            
            if (listSV[i].Length > maxLength)
            {
                maxLength = listSV[i].Length;
                maxName = listSV[i];
            }
            Console.WriteLine(listSV[i]);
        }
        Console.WriteLine("Ten sinh vien dai nhat la " + maxName);

    }
    //Exercise 4:
    public static void DictionarySV()
    {
        Console.WriteLine("Program: Danh sach sinh vien");
        //Tao danh dach sinh vien
        Dictionary<string, string> DicSV = new Dictionary<string, string> ();
        //Them sinh vien moi
        bool access = false;
        while (!access)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Tim kiem sinh vien theo ma SV");
            Console.WriteLine("3. Thoat");
            int x = in_put_int();
            if(x == 3)
            {
                access = true;
            }
            else if( x == 1)
            {
                Console.WriteLine("Them ma sinh vien moi");
                string maSV = Console.ReadLine();
                Console.WriteLine("Them ten sinh vien moi");
                string tenSV = Console.ReadLine();
                DicSV.Add(maSV, tenSV);
            }
            else if(x == 2)
            {
                if (DicSV.Count == 0)
                {
                    Console.WriteLine("Chua co sinh vien nao");
                }
                else
                {
                    Console.WriteLine("Nhap ma sinh vien ban muon tim kiem");
                    string maSV_search = Console.ReadLine();

                    string values = "";
                    if(DicSV.TryGetValue(maSV_search,out values))
                    {
                        Console.WriteLine("Sinh vien co ma so " + maSV_search + " la " + values);

                    }
                    else
                    {
                        Console.WriteLine("Khong tim thay");
                    }

                }
            }
        }
    }
    //Excercise 5:
    class Student
    {
        public string Name;
        public string Id;
        public int Score;

        public Student()
        {
            
        }
        public void Display()
        {
            Console.WriteLine(" Sinh vien " + Name + " co " + Id + " dat duoc " + Score);
        }
    }
    public static void classStudent()
    {
        Console.WriteLine("Program: Tao lop Student");
        List<Student> students = new List<Student>();
        bool access = false;
        while (!access)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. In ra danh sach sinh vien ");
            Console.WriteLine("3. Exit");
            int x = in_put_int();
            if(x == 3)
            {
                access = true;
            }
            else if (x == 1)
            {
                Student student_new = new Student();
                Console.WriteLine("Nhap ten sinh vien");
                student_new.Name = Console.ReadLine();
                Console.WriteLine("Nhap Id sinh vien");
                student_new.Id = Console.ReadLine();
                Console.WriteLine("Nhap diem sinh vien");
                student_new.Score = in_put_int();
                student_new.Display();
            }
        }
        


    }
    public static void Main(string[] args)
    {
        //Exercise 1: 
        //Diemso();
        //Exercise 2:
        //NhapDiemSo();
        //Exercise 3:
        //ListSV();
        //Exercise 4:
        //DictionarySV();
        //Exercise 5:
        classStudent();



        

    }
}
