internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        #region funtion trong List của Collection
        // // khởi tạo danh sách
        // List<int> numbers = new List<int>();
        // // Nhập n từ bàn phím với n là số lượng phần tử của mảng
        // Console.WriteLine("Mời nhập số lượng phần tử: ");
        // string? n = Console.ReadLine();
        // int formatN = Convert.ToInt32(n);
        // for (int i = 0; i < formatN; i++)
        // {
        //     Console.WriteLine($"Mời bạn nhập số thứ {i + 1}");
        //     int number = Convert.ToInt32(Console.ReadLine());
        //     numbers.Add(number);
        // }

        // Console.WriteLine("Danh sách phần tử đã nhập là: ");
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }

        // // dùng join
        // Console.WriteLine(String.Join(", ", numbers));

        // // Dùng sort để sắp xếp phần tử trong mảng
        // numbers.Sort();
        // Console.WriteLine("Danh sách phần tử đã sắp xếp là: ");
        // Console.WriteLine(String.Join(", ", numbers));

        // // dùng reverse
        // numbers.Reverse();
        // Console.WriteLine("Danh sách phần tử sau khi Reverse là: ");
        // Console.WriteLine(String.Join(", ", numbers));
        #endregion

        #region  Bài 1: Tính tổng các số lớn hơn 50
        // List<int> lstNumber = new List<int> { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
        // int tong = Bai1.tinhTongSoLon50(lstNumber);
        // Console.WriteLine("Tổng các số lớn hơn 50: " + tong); // Output: 313
        #endregion

        #region  Bài 2: Tìm số lớn nhất trong mảng
        // List<int> numbers = new List<int> { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
        // int max = Bai2.timSoLonNhat(numbers);
        // Console.WriteLine("Số lớn nhất là: " + max); // Output: 313
        #endregion

        #region  Bài 3: Tìm những chữ bắt đầu bằng chữ m
        // List<string> n = new List<string>{ "apple", "banana", "orange", "kiwi", "mango", "pineapple", "grape", "melon" };
        // List<string> mStrings = Bai3.findAllStartM(n);
        // Console.WriteLine("Danh sách phần tử bắt đầu bằng m là:");
        // foreach (string str in mStrings) {
        //     Console.WriteLine(str); 
        // }
        #endregion

        #region Bài 4: In ra các phần tử không trùng nhau
        // List<int> lstNumbers= new List<int> { 1, 1, 2, 2, 2, 3, 4, 4, 5 };
        // List<int> lstResult = Bai4.uniqueNumber(lstNumbers);

        // Console.WriteLine("Độ dài của danh sách mới: ");
        // foreach (int result in lstResult) {
        //     Console.WriteLine(result);
        // }
        #endregion

        #region tìm hiểu về dictionary trong collection
        Dictionary<string, string> dic = new Dictionary<string, string>();
        
        //thêm key-value vào dic
        dic.Add("Alice", "test");
        dic["Do"] = "Nam Trung";

        // duyệt dic
        foreach (KeyValuePair<string, string> pointer in dic){
            // pointer: key-value
            Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}");
        }

        // chỉ duyệt mỗi key hoặc value => y chang như bên List
        //chỉ duyệ key
        Console.WriteLine("Danh sách các key là: ");
        foreach (string str in dic.Keys){
            Console.WriteLine(str);
        }

        //c2
        // if(int i = 0; i < dic.Keys.Count; i ++){
        //     Console.WriteLine(dic.Keys.ElementAt(i));
        // }

        //update value cho dic
        dic["Alice"] = "Johnson";
        Console.WriteLine("Dic sau khi update: ");
        foreach (KeyValuePair<string, string> pointer in dic){
            Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}");
        }

        //xoa key-value cho dic
        dic.Remove("Alice");
        Console.WriteLine("Dic sau khi remove: ");
        foreach (KeyValuePair<string, string> pointer in dic){
            Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}");
        }
        #endregion
    }
}