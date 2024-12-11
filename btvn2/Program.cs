#region Tính số ngày trong tuần và số ngày lẻ còn lại
// INPUT
// B1: Nhập vào ngày cần tính
Console.WriteLine("Nhập vào số ngày: ");
string date = Console.ReadLine();
// B2:convert string -> int
int formatDate = Convert.ToInt32(date);

//PROCESS
// weeks =  formatDate / 7
//remainingDays = formatDate % 7
int weeks =  formatDate / 7;
int remainingDays = formatDate % 7;

// OUTPUT
//in ra số tuần và ngày lẽ còn lại
Console.WriteLine($"{formatDate} này tương ứng với {weeks} tuần và {remainingDays} ngày");
#endregion

#region Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
// INPUT
// B1: Nhập vào giá trị gốc và phần trăm giảm giá
Console.WriteLine("Nhập vào giá trị gốc của đơn hàng: ");
string gia = Console.ReadLine();
Console.WriteLine("Nhập vào phần trăm giảm giá (0-100): ");
string giamGia = Console.ReadLine();
// B2:convert string -> double
double giaGoc = Convert.ToDouble(gia);
double phanTramGiamGia = Convert.ToDouble(giamGia);

// PROCESS
// Tính số tiền giảm giá: soTienGiamGia = (phanTramGiamGia / 100) * giaGoc
double soTienGiamGia = phanTramGiamGia / 100 * giaGoc;
// Tính tổng giá trị sau khi giảm giá : tongGiaTriSauGiamGia = giaGoc - soTienGiamGia
double tongGiaTriSauGiamGia = giaGoc - soTienGiamGia;

// OUTPUT
// In ra tổng giá trị đơn hàng sau khi giảm giá
Console.WriteLine($"Tổng giá trị sau khi áp dụng giảm giá là: {tongGiaTriSauGiamGia}");
#endregion

#region Chuyển đổi thời gian từ phút sang giờ và phút
//INPUT
// B1: Nhập số phút từ bàn phím
Console.Write("Nhập số phút: ");
string soPhut = Console.ReadLine();
// B2: convert string -> int
int tongSoPhut = Convert.ToInt32(soPhut);

// PROCESS
// gio = tongSoPhut / 60
// phut = tongSoPhut % 60
int gio = tongSoPhut / 60;
int phut = tongSoPhut % 60;

//OUTPUT
Console.WriteLine($"{tongSoPhut} phút tương đương với {gio} giờ và {phut} phút");
#endregion

#region Tính tổng số tiền sau khi cộng thêm thuế VAT
// INPUT
// B1: Nhập vào số tiền gốc và tỷ lệ thuế VAT từ bàn phím
Console.Write("Nhập số tiền gốc: ");
string soTienGoc = Console.ReadLine();
Console.Write("Nhập tỷ lệ thuế VAT: ");
string tyLeVAT = Console.ReadLine();
// B2: convert string -> double
double formatSoTienGoc = Convert.ToDouble(soTienGoc);
double formatTyLeVAT = Convert.ToDouble(tyLeVAT);

// PROCESS
// double tongSoTien = soTienGoc + soTienGoc * (tyLeVat / 100)
double tongSoTien = formatSoTienGoc + formatSoTienGoc * (formatTyLeVAT / 100);

// OUTPUT
Console.WriteLine($"Tổng số tiền sau khi cộng thuế VAT là: {tongSoTien}");
#endregion

#region Chuyển đổi đơn vị tiền tệ
// INPUT
// B1: Nhập số tiền USD và tỷ giá
Console.WriteLine($"Nhập số tiền (USA): ");
string tien = Console.ReadLine();
Console.WriteLine($"Nhập tỷ giá");
string tyGia = Console.ReadLine();
// B2: convert string -> double
double formatTien = Convert.ToDouble(tien);
double formatTyGia = Convert.ToDouble(tyGia);

//PROCESS
double tienVND = formatTien * formatTyGia;

//OUTPUT
Console.WriteLine($"{formatTien}USD tương ứng với {tienVND}VND");
#endregion