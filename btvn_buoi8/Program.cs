internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Bài 1: Tính tổng các số trong mảng
        List<int> IstNumber1 = new List<int> { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
        int sum = Bai1.TinhTong(IstNumber1);
        Console.WriteLine(sum);

        // Bài 2: Tìm hai sốIstNumber1 trong tổng danh sách số nguyên sao cho tổng của chúng bằng một giá trị target cho trước
        List<int> lst = new List<int> { 2, 7, 11, 15 };
        int target = 9;

        if (Bai2.twoSumDictionary(lst, target) == null)
        {
            Console.WriteLine("Không có 2 số nào có tổng bằng target");
        }
        else
        {
            List<int> indexes = Bai2.twoSumDictionary(lst, target);
            Console.WriteLine($"[{string.Join(", ", indexes)}]");
        }

        // Bài 3:Loại bỏ các phần tử trùng lặp từ một mảng đã sắp xếp và trả về chiều dài của mảng mới.
        List<int> IstNumber3 = new List<int> { 1, 1, 2, 2, 2, 3, 4, 4, 5 };
        List<int> result = Bai3.RemoveDuplicates(IstNumber3);
        int length = result.Count;
        Console.WriteLine(length);

        // Bài 4: Remove duplicates from sorted Array(Easy)

        // Bài 5: Best time to Buy and Sell Stock
        List<int> prices = new List<int> { 7, 1, 5, 3, 6, 4 };
        int maxProfit = Bai5.MaxProfit(prices);
        Console.WriteLine(maxProfit);
    }
}