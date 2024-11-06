class Bai2
{
    public static int timSoLonNhat(List<int> numbers)
    {
        int max = 0;
        foreach (int number in numbers){
            if (number > max){
                max = number;
            }
        }
        return max;
    }
}