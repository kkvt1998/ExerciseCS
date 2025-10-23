using System;

class baitap 
{
    //Hàm kiểm tra nhập vào có phải số nguyên hay không
    public static string in_put() 
    {
        string x = "";
     
        bool check = false;
        while (!check)
        {
            x = Console.ReadLine();
            if (int.TryParse(x, out int result))
            {
                check = true;

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer:");
            }
        }
        return x;
    }
    //Hàm thực hiện nhập vào danh sách List
    public static void inputList(List<int> nums) 
    {
        Console.WriteLine("Enter the number of elements in the list:");
        int n = int.Parse(in_put());
        for (int i = 0; i < n; i++) 
        {
            Console.WriteLine("Enter element " + (i + 1) + ":");
            int element = int.Parse(in_put());
            nums.Add(element);
        }
        showList(nums);
    }
    //Hàm thực hiện gộp 2 danh sách và sắp xếp
    public static void mergeList(List<int> x, List<int> y) 
    {
        int n = y.Count;
        for (int i = 0; i < n; i++) 
        {
            x.Add(y[i]);
        }
        
        sortingList(x);

    }
    //Hàm hiển thị danh sách
    public static void showList(List<int> x) 
    {
        foreach (int i in x) 
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    //Hàm sắp xếp danh sách
    static void sortingList(List<int> x) 
    {
        for(int i = 0; i < x.Count - 1; i++) 
        {
            for (int j = i + 1; j < x.Count; j++) 
            {
                if (x[i] > x[j]) 
                {
                    int temp = x[i];
                    x[i] = x[j];
                    x[j] = temp;
                }
            }
        }

    }
   
    public static void Main(string[] args) 
    {
        Console.WriteLine("Sorting list");
        List<int> nums1 = new List<int>();
        List<int> nums2 = new List<int>();
        //Nhập vào danh sách 1
        Console.WriteLine("Enter the first list element!");
        inputList(nums1);
        sortingList(nums1);
        //Nhập vào danh sách 2
        Console.WriteLine("Enter the second list element!");
        inputList(nums2);
        sortingList(nums2);
        Console.WriteLine("----------------------------------");
        mergeList(nums1, nums2);
        //Hiển thị danh sách sau khi gộp và sắp xếp
        Console.WriteLine("The merged and sorted list is:");
        showList(nums1);
    }
}