// See https://aka.ms/new-console-template for more information
using System.IO.Compression;
using System.Net.NetworkInformation;

Console.WriteLine("Hello, World!");

#region Học phép toán cơ bản
// toán tử +, -, *, /, %(chia lấy dư)
//khai báo biến
// int add = 5 + 10; 
// Console.WriteLine($"Kết quả cộng hai số 5 và 10 là: {add}");

// int minus = 1231231 - 34546;
// Console.WriteLine($"Kết quả trừ hai số 1231231 và 34546 là: {minus}");

// int mul = 123 * 34;
// Console.WriteLine($"Kết quả nhân hai số 123 và 34 là: {mul}");

// int div = 5 / 2;
// Console.WriteLine($"Kết quả chia lấy phần nguyên hai số 5 và 2 là: {div}");

// int div1 = 5 % 2;
// Console.WriteLine($"Kết quả chia lấy dư hai số 5 và 2 là: {div1}");

#endregion

#region numberic toán tử
// int cong = 0; // định nghĩa biến cong có giá trị mặc định 0
// cong += 10;
// Console.WriteLine($"Numberic toán tử cộng: {cong}");

// int tru = 15;
// tru -= 10;
// Console.WriteLine($"Numberic toán tử trừ: {tru}");

// int nhan = 1;
// nhan *= 10;
// Console.WriteLine($"Numberic toán tử nhân: {nhan}");

#endregion

#region ép kiểu dữ liệu C1: Dùng Convert
// Convert
// Nhập dữ liệu từ bàn phím => ReadLine(string)
Console.WriteLine("Mời bạn nhập số: ");
string number = Console.ReadLine();

int convertNumber = Convert.ToInt32(number);
int sum = convertNumber + 1;

Console.WriteLine($"value number: {sum}");
#endregion

#region Tính c hỉ số BMI
// INPUT
// Chiều cao và cân nặng được nhập từ bàn phím
Console.WriteLine("Mời bạn nhập chiều cao (m): ");
string chieuCao = Console.ReadLine(); // Nhập từ bàn phím luôn luôn la 2 kiểu string

// convert string -> double
double formatChieuCao = Convert.ToDouble(chieuCao);

Console.WriteLine("Mời bạn nhập cân nặng (kg): ");
string canNang = Console.ReadLine();

double formatCanNang = Convert.ToDouble(canNang);


// OUTPUT
// In ra chỉ số BMI
// Khởi tạo biến bmi để lưu giá trị BMI
double bmi = 0.0; 

// PROCESS
// BMI = (cân nặng) / [(chiều cao) * (chiều cao)]
bmi = formatCanNang / (formatChieuCao * formatChieuCao);
Console.WriteLine($"Chỉ số BMI của bạn là: {bmi}");

#endregion

#region Tính chu vi và diện tích hình tròn
// INPUT
// B1: Nhập bán kính từ bàn phím
Console.WriteLine("Mời bạn nhập bán kính hình tròn:");
string banKinh = Console.ReadLine();
// B2: convert kiểu dữ liệu string -> double
double formatBanKinh = Convert.ToDouble(banKinh);

// OUTPUT
double chuVi = 0.0;
double dienTich = 0.0;

// PROCESS
// chuVi = 2 * pi * banKinh
// dienTich = pi * banKinh * banKinh
double PI = Math.PI;
chuVi = 2 * PI * formatBanKinh;
dienTich = PI * formatBanKinh * formatBanKinh;

Console.WriteLine($"Chu vi hình tròn là: {chuVi}");
Console.WriteLine($"Diện tích hình tròn là: {dienTich}");

#endregion