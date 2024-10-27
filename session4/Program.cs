// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Hello, World!");

// while
// for
// do...while
// quan trọng nhất là xác định điều kiện dừng

#region while statement
// In ra các số từ 1 -> n với số được nhập từ bàn phím
// B1: khởi tạo giá trị lặp
// B2: xác định đk lặp (tính tới trường hợp dừng)
// B3: thay đổi đk lặp
// Console.WriteLine("Mời bạn nhập số: ");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
// int count = 1;
// while(count <= formatNumber){
//     Console.WriteLine(count);
//     count ++; // count = count + 1
// }

// Nhập số n từ bàn phim in ra tổng các số từ 1 -> n
// S = 1 + 2 + 3 +...+ n
// Console.WriteLine("Mời bạn nhập số: ");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
// int count = 1;
// int S = 0;
// while(count <= formatNumber){
//     S = S + count; // 
//     count ++;
// }
// Console.WriteLine($"Tổng các số từ 1 -> n là {S}");

// Tính giai thừa của 1 số nhập từ bàn phím
// Console.WriteLine("Mời bạn nhập số: ");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
// int count = 1;
// int factorial = 1;
// while(count <= formatNumber){
//     factorial *= count; // 
//     count ++;
// }
// Console.WriteLine($"Giai thừa của {number} là {factorial}");

// In bảng cửu chương
// Console.WriteLine("Mời bạn nhập số: ");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
// int count = 1;
// int a = 0;
// while(count <= 10){
//     a = formatNumber * count; // 
//     Console.WriteLine($"{count} * {number} = {a}");
//     count ++;
// }

// Nhập số n từ bàn phím kiểm tra xem số đó có phải số nguyên tố hay không
// giả sử a và b là ước của n 
// ít nhất a và b phải nhỏ hơn căn bậc 2 của n
// vì nếu a và b > căn bậc 2 của n -> a+b > n
// VD: n=9 => căn bậc 2 của 9 = 3
// Console.WriteLine("Mời bạn nhập số: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// while(count < number){ // count < Math.Sqrt(number), (count < căn bậc 2 của n)
//     if(number % count == 0){
//         Console.WriteLine($"Số {number} không phải là số nguyên tố.");
//         break;
//     }
//     count++; // quan trọng
// }

// if(count == number){
//     Console.WriteLine($"Số {number} là số nguyên tố.");
// }
#endregion
//In bảng cửu chương
// Console.WriteLine("Mời bạn nhập số: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= 10; i++){
//     Console.WriteLine($"{i} * {number} = {i* number}");
// }

// Nhập số n từ bàn phím kiểm tra xem số đó có phải số nguyên tố hay không
// Console.WriteLine("Mời bạn nhập số: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count;

// for( count = 2; count < number; count++){ // count < Math.Sqrt(number), (count < căn bậc 2 của n)
//     if(number % count == 0){
//         Console.WriteLine($"Số {number} không phải là số nguyên tố.");
//         break;
//     }
// }

// if (count == number)
// {
//     Console.WriteLine($"Số {number} là số nguyên tố.");
// }

// // Nhập số dòng và số cột từ người dùng
// Console.WriteLine("Nhập số dòng: ");
// int soDong = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Nhập số cột: ");
// int soCot = Convert.ToInt32(Console.ReadLine());
// // Sử dụng hai vòng lặp for lồng nhau (Ma trận)
// for (int i = 0; i < soDong; i++)
// {
//     for (int j = 0; j < soCot; j++)
//     {
//         Console.Write("*"); // In dấu sao
//     }
//     Console.WriteLine(); // Xuống dòng sau mỗi hàng
// }

// In ra tam giác cân
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
        Console.Write("*");
    }
    
    Console.WriteLine();
}
#region for statement 

#endregion
