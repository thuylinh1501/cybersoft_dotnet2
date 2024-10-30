// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
internal class Program
{
    private static void Main(string[] args)
    {
        // gọi hàm
        int ketQua = tinhTong(10, 11);
        Console.WriteLine($"Tổng hai số là {ketQua}");
        //In ra số nguyên tố
        Console.WriteLine("Mời bạn nhập số: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Số nguyên tố:  ");
        for (int count = 2; count < number; count++)
        { 
            bool checkPrime = isPrime(count);

            if (checkPrime == true)
            {
                Console.Write($"{count} ");
            }
        }
        Console.WriteLine();
        // KT số nghịch đảo
         Console.WriteLine("Nhập số để kiểm tra số đối xứng: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        bool kiemTra = getReverseNumber(number1);
        if (kiemTra == true)
        {
            Console.WriteLine($"{number1} là số đối xứng");
        }
        else
        {
            Console.WriteLine($"{number1} không là số đối xứng");
        }
    }

    //Khai báo hàm

    static bool getReverseNumber(int n)
    {
        int reverseNumber = 0;
        int originalNumber = n;

        while (n > 0)
        {
            int lastDigit = n % 10;
            reverseNumber = reverseNumber * 10 + lastDigit;
            n = n / 10;
        }

        return reverseNumber == originalNumber;
    }
    private static bool isPrime(int number)
    {
        if (number <= 2)
        {
            return false;
        }
        for (int count = 2; count <= Math.Sqrt(number); count++)
        {
            if (number % count == 0)
            {
                return false;
            }
        }
        return true;
    }

    private static int tinhTong(int number1, int number2)
    {
        return number1 + number2;
    }
}