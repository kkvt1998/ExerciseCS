using System;

namespace Test2
{
    class Program
    {
        // Tao delegate
        public delegate void DiscountEventHandler(string name, int oldPrice, int newPrice);
        public class Phone
        {
            public string Name;
            public int Price;
            // Constructor
            public Phone(string name, int price)
            {
                this.Name = name;
                this.Price = price;
            }
            // Method to display phone information
            public virtual void ShowInfo()
            {
                Console.WriteLine($"Phone Name: {Name}, Price: {Price}");
            }
            // sự kiện  giảm giá
            public event DiscountEventHandler OnDiscount;

            // phương thức để giảm giá
            public void ApplyDiscount(int percent)
            {
                // gán giá cũ
                int oldPrice = Price;
                // tính giá mới
                int newPrice = Price - (Price * percent / 100);
                Price = newPrice;
                // kích hoạt sự kiện nếu có người đăng ký
                if(OnDiscount != null)
                {
                    OnDiscount(Name, oldPrice, newPrice);
                }

            }
        }
        // Tạo class Store
        public class Store
        {
            List<Phone> phones = new List<Phone>();
            // phương thức để thêm điện thoại
            public void Add_Phone(Phone phone)
            {
                phones.Add(phone);
            }
            // Phương thức  để giảm giá tất cả điện thoại
            public void DiscountAll(int percent)
            {
                //áp dụng lên tất cả điện thoại
                foreach(var phone in phones){
                    phone.ApplyDiscount(percent);
                }
            }
            // phương thức hiển thị tất cả điện thoại
            public void ShowPhoneStore()
            {
                foreach(var phone in phones)
                {
                    phone.ShowInfo();
                }
            }
        }

        public static void Bai_1()
        {
            Phone []
            phones = new Phone[3];
            phones[0] = new Phone("iphone", 20000);
            phones[1] = new Phone("samsung", 15000);
            phones[2] = new Phone("xiaomi", 10000);

            // Hiển thị thông tin và giá từng điện thoại trong mảng
            foreach (var phone in phones)
            {
                phone.ShowInfo();
            }
            // Thay đổi thông tin của đối tượng phone[0]

            Phone p1 = phones[0];
            p1.Price = 9999;

            // Hiển thị thông tin và giá từng điện thoại trong mảng sau khi thay đổi đối tượng phone[0]
            Console.WriteLine("---------------After change information of the phone[0]-----------------------------");
            foreach (var phone in phones)
            {
                phone.ShowInfo();
            }
            // Bởi vì kiểu Phone là kiểu tham chiếu nên p1 sẽ tham chiếu đến cùng một vùng nhớ với đối tượng phones[0].
            // Do đó, khi thay đổi thuộc tính Price của p1, thuộc tính Price của phones[0] cũng bị thay đổi theo.

            // Thay Array bằng List để thêm nhiều điện thoại hơn
            List<Phone> phones_List = new List<Phone>();
            // Thêm đối tượng Phone vào List bằng phương thức Add
            phones_List.Add(new Phone("iphone", 20000));
            phones_List.Add(new Phone("redmi", 15000));
            //Hiển thị thông tin và giá từng điện thoại trong List
            Console.WriteLine("---------------List of Phones-----------------------------");
            foreach (var phone in phones_List)
            {
                phone.ShowInfo();
            }
                    
        }
        //Tạo ra class SmartPhone kế thừa từ class Phone
        public class SmartPhone : Phone
        {
            public string os;
            // constructor
            public SmartPhone(string name, int price, string os): base(name, price)
            {
                this.os = os;
            }
            // override phương thức ShowInfo để hiển thị thêm thông tin os
            public override void ShowInfo()
            {
                Console.WriteLine($"Phone Name: {Name}, Price: {Price}, OS: {os}");
            }

        }
        // Thực thi bài số 2:
        public static void Bai_2()
        {
            // Tạo ra đối tượng store
            Store store = new Store();
            // Tạo ra 3 điện thoại
            Phone phone1 = new Phone("iPhone 17", 50000);
            Phone phone2 = new Phone("samsung s25 ultra", 30000);
            Phone phone3 = new Phone("xiaomi note 10", 50000);
            // Thêm điện thoại vào cửa hàng
            store.Add_Phone(phone1);
            store.Add_Phone(phone2);
            store.Add_Phone(phone3);
            Console.WriteLine("---------------Phone Store-----------------------------");
            store.ShowPhoneStore();
            // Hàm xử lí sự kiện Giảm giá điện thoại
            Console.WriteLine("---------------Event Discount Phones-----------------------------");
            static void ShowDiscountMessage(string name, int oldPrice, int newPrice)
            {
                Console.WriteLine($"Phone {name} has been discounted from {oldPrice} to {newPrice}");
            }
            // Đăng kí sự kiện discount cho từng điện thoại
            phone1.OnDiscount += ShowDiscountMessage;
            phone2.OnDiscount += ShowDiscountMessage;
            phone3.OnDiscount += ShowDiscountMessage;
            
            // Gọi hàm DiscountAll với percent = 10 cho cửa hàng
            store.DiscountAll(10);
            // hiển thị thông tin tất cả điện thoại trong cửa hàng sau giảm giá
            Console.WriteLine("---------------Phone Store after discount-----------------------------");
            store.ShowPhoneStore();
           
            // ví dụ thêm vào Store một vài SmartPhone
            Console.WriteLine("---------------Add SmartPhone to Store-----------------------------");
            SmartPhone sp_1 = new SmartPhone("iphone 14 pro", 70000, "iOS");
            SmartPhone sp_2 = new SmartPhone("Samsung Galaxy A01", 44000, "Android");
            store.Add_Phone(sp_1);
            store.Add_Phone(sp_2);
            store.ShowPhoneStore();
        }

        public static void Main(string[] args)
        {
                // Thực thi bài số 1
                //Bai_1();
                // thực thi bài số 2
                //Bai_2();
        }
        
    }
}