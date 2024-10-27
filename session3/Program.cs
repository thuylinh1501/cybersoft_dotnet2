// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
#region Bài tập số 2

#region if-else statement
// Nhập vào số nguyên từ bàn phím. In ra số đó là số lẻ hay chẵn
// INPUT
// Boolean flag = true;
// while(flag){
//     Console.WriteLine("Mời bạn nhập số nguyên: ");
//     string? number = Console.ReadLine();
//     try{
//         int test = Convert.ToInt32(number);
//         flag = false;
//     } catch{
//         flag = true;
//     }
// }

// Console.WriteLine("Mời bạn nhập số: ");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
// if(formatNumber % 2 == 0){
//     Console.WriteLine($"Số {number} là số chẵn");
// } else{
//     Console.WriteLine($"Số {number} là số lẻ");
// }
// OUTPUT

// PROCESS


// Truethy:
int day = 5;
if(day != 0){
    Console.WriteLine("Truthy");
}

// Nhập điểm tb của hs. Xuất ra học lực của hs đó
// >= 9 : Xuất sắc
// 8 <= điểm < 9 : Giỏi
// 6.5 <= điểm < 8: Khá
// 5 <= điểm < 6.5: TB
// 3.5 <= điểm < 5: Yếu
// Quá kém

// Console.WriteLine("Mời bạn nhập điểm: ");
// string? diemTB = Console.ReadLine();
// double formatDiemTB = Convert.ToDouble(diemTB);
// if(formatDiemTB >= 9){
//     Console.WriteLine("Xuất sắc");
// } else if (formatDiemTB >= 8 && formatDiemTB < 9){
//     Console.WriteLine("Giỏi");
// } else if(formatDiemTB >= 6.5 && formatDiemTB < 8){
//     Console.WriteLine("Khá");
// } else if(formatDiemTB >= 5 && formatDiemTB < 6.5){
//     Console.WriteLine("Trung bình");
// } else if(formatDiemTB >= 3.5 && formatDiemTB < 5){
//     Console.WriteLine("Yếu");
// } else{
//     Console.WriteLine("Quá kém");
// }

// Console.WriteLine("Mời bạn nhập số có 3 chữ số: ");
// string? so = Console.ReadLine();
// int formatSo = Convert.ToInt32(so);
// if(formatSo >= 100 &&  formatSo <= 999){
//     int a = formatSo / 100;
//     int b = (formatSo /10) % 10;
//     int c = formatSo % 10;
//     int tong = a + b + c;
//     Console.WriteLine($"Tổng của 3 số là: {tong}");
// } else{
//     Console.WriteLine("Đây không phải là  số có 3 chữ số");
// }



// BTVN: Nhập ngày (dd/mm/yy). In ra thứ mấy trong tuần
// VD: 23/10/2024 => Thứ tư
//Lưu ý không dùng thư viện
// INPUT

// OUTPUT

// PROCESS


// switch ... case
// C1: Dùng switch...case
// Nhập số có trong khoảng từ 1 -> 10. Đọc số
Console.WriteLine("Mời bạn nhập số có trong khoảng từ 1 -> 10: ");
string? number2 = Console.ReadLine();
int formatNumber2 = Convert.ToInt32(number2);
switch (formatNumber2){
    case 1:
        Console.WriteLine("Số 1");
        break;
    case 2:
        Console.WriteLine("Số 2");
        break;
    case 3:
        Console.WriteLine("Số 3");
        break;
    case 4:
        Console.WriteLine("Số 4");
        break;
    case 5:
        Console.WriteLine("Số 5");
        break;
    case 6:
        Console.WriteLine("Số 6");
        break;
    case 7:
        Console.WriteLine("Số 7");
        break;
    case 8:
        Console.WriteLine("Số 8");
        break;
    case 9:
        Console.WriteLine("Số 9");
        break;
    default:
        Console.WriteLine("Số 10");
        break;
}
// C2: Dùng switch expression
#endregion

#endregion