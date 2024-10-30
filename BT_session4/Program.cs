// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
#region In ra số nguyên tố từ 2 -> n
Console.WriteLine("Mời bạn nhập số: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Số nguyên tố:  ");
for (int i = 2; i < number; i++)
{
    Boolean isPrime = true;
    for (int j= 2; j < Math.Sqrt(i); j++)
    { // count < Math.Sqrt(number), (count < căn bậc 2 của n)
        if (i % j == 0)
        {   
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.Write($"{i} ");
    }
}
Console.WriteLine();
#endregion

#region Nhập chiều cao tam giác. In ra tam giác rỗng
Console.Write("Nhập chiều cao tam giác cân: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= n; i++)
{
    // In khoảng trắng
    for (int j = 0; j <= n - i - 1; j++)
    {
        Console.Write(" ");
    }

    // In dấu sao
    for (int k = 0; k < 2 * i + 1; k++)
    {
        if (k == 0 || k == 2 * i || i == n)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
#endregion

#region 
Console.WriteLine("Nhập số để kiểm tra số đối xứng: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int reverseNumber =  0;
int originalNumber = n1;
//B1: Lấy số 1 => dư = n1 % 10
// reverseNumber = reverseNumber * 10 + dư
// n1 = n1 /10
while(n1 > 0){
    int lastDigit = n1 % 10;
    reverseNumber = reverseNumber * 10 + lastDigit;
    n1 = n1 / 10;
}

if(originalNumber == reverseNumber){
    Console.WriteLine($"{originalNumber} là số đối xứng");
}else{
    Console.WriteLine($"{originalNumber} không là số đối xứng");
}
#endregion