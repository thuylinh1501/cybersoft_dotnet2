class Bai3 {
    public static List<int> RemoveDuplicates(List<int> numbers){
        List<int> uniqueNums = new List<int>();
        foreach (int num in numbers)
        {
            if (!uniqueNums.Contains(num))
            {
                uniqueNums.Add(num);
            }
        }
        return uniqueNums;
    }
}