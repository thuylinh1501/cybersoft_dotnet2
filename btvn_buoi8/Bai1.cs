class Bai1{
    public static int TinhTong(List<int> numbers){
        int sum = 0;
        for (int i = 0; i < numbers.Count; i++){
            sum += i;
        }
        return sum;
    }
}
