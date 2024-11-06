class Bai1
{
    public static int tinhTongSoLon50(List<int> numbers)
    {
        int tong = 0;
        // for (int i = 0; i < numbers.Count; i++)
        // {
        //     if (numbers[i] >= 50)
        //     {
        //         tong += numbers[i];
        //     }
        // }

        foreach(int number in numbers){
            if(number >= 50){
                tong += number;
            }
        }
        return tong;
    }
}