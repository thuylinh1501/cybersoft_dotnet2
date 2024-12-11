// Ôn lại function
// sơ lược collection
internal class Program
{
    private static void Main(string[] args)
    {
        #region kiểm tra số nguyên tố
        // Console.WriteLine("Mời bạn nhập số");
        // string? number = Console.ReadLine();
        // int formatNumber =  Convert.ToInt32(number);
        // bool isPrime = Method.checkPrime(formatNumber);
        // if(isPrime == true){
        //     Console.WriteLine($"Số {number} là số nguyên tố");
        // }else {
        //     Console.WriteLine($"Số {number} không là số nguyên tố");
        // }
        #endregion

        #region in ra tam giác vuông
        // Console.WriteLine("Mời bạn nhập chiều cao tam giác: ");
        // string? height = Console.ReadLine();
        // int formatHeight =  Convert.ToInt32(height);
        // Method.printSquareTriangle(formatHeight);
        #endregion

        #region collection trong C#
        // data structure
        // List
        List<int> numbers = new List<int>();
        
        // define giá trị ban đầu
        List<string> names = new List<string>{"Phuong", "Duc", "Linh", "Hung", "Tri"};
        //                            index       0        1       2       3      4
        //                         reverseIndex   ^5       ^4      ^3      ^2     ^1
        // Lưu ý: WriteLine chỉ in được giá trị cho những giữ liệu nguyên thuỷ như là int, string ,..
        // Còn kiểu dữ liệu Collection thì chỉ in ra vùng nhớ của biến đó
        Console.WriteLine($"Phần tử thứ 2 là: {names[2]}");
        Console.WriteLine($"Phần nghịch đảo là: {names[^3]}");
        Console.WriteLine(String.Join(", ", names));

        // Nhập n từ bàn phím. Sau đó nhập n phần tử và xuất ra n phần tử
        Console.WriteLine("Mời bạn nhập số lượng phần tử: ");
        string? number = Console.ReadLine();
        int formatNumber = Convert.ToInt32(number);
        // tạo list chứa danh sách phần tử
        List<int> listNumbers = new List<int>();
        for (int i = 0; i < formatNumber; i++){
            // C1: Dùng insert
            Console.WriteLine($"Nhập phần tử thứ {i+1}");
            String? item = Console.ReadLine();
            int formatItem = Convert.ToInt32(item);
            // listNumbers.Insert(i, formatItem); // c1

            //c2: dùng add: thêm phần tử vào cuối ds
            listNumbers.Add(formatItem);
        }

        // in list phần tử
        // có 2 cách duyệt phần tử: for or foreach
        // C1: for
        Console.WriteLine("Danh sách phần tử sau khi nhập là:");
        for(int i = 0; i < listNumbers.Count; i++){
            Console.WriteLine(listNumbers[i]);
        }
        // C2: foreach
         Console.WriteLine("Danh sách phần tử dùng foreach là:");
        foreach(int item in listNumbers){
            Console.WriteLine(item);
        }
        #endregion
    }
}
