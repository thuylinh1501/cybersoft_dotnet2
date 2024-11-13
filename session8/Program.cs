internal class Program
{
    private static void Main(string[] args)
    {
        #region Bài 1
        List<int> lst = new List<int> { 2, 7, 9, 11, 15 };
        int target = 26;

        Console.WriteLine("Bài 1: Tìm 2 số để tổng 2 số băng target");
        if (TwoSum.twoSum(lst, target) == null)
        {
            Console.WriteLine("Không có 2 số nào có tổng bằng target");
        }
        else
        {
            List<int> indexes = TwoSum.twoSum(lst, target);
            Console.WriteLine($"Chỉ số 2 số có tổng bằng target là {string.Join(", ", indexes)}");
        }

        Console.WriteLine("Cách 2 dùng dictionary");
        if (TwoSum.twoSumDictionary(lst, target) == null)
        {
            Console.WriteLine("Không có 2 số nào có tổng bằng target");
        }
        else
        {
            List<int> indexes = TwoSum.twoSumDictionary(lst, target);
            Console.WriteLine($"Chỉ số 2 số có tổng bằng target là {string.Join(", ", indexes)}");
        }
        #endregion

        #region Bài 2
        List<string> words = new List<string>() { "apple", "banana", "apple", "cherry", "banana", "apple" };
        Dictionary<string, int> result = WordCount.wordCount(words);
        foreach (var kvp in result)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        #endregion

        #region Khái niệm về cách lưu trữ biến trong máy tính

        #endregion
    }
}