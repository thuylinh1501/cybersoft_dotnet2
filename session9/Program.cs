internal class Program
{
    private static object baiviet2;

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // bản chất của OOP đó chính là gom nhóm
        // các biến được gọi là các thuộc tính
        // chữ cái đầu tiên của class phải IN HOA

        BaiViet baiviet1 = new BaiViet();
        baiviet1.tieuDe = "Siêu bão Manyi sắp vào Biển Đông";
        baiviet1.hinhAnh = "hinh1.png";
        baiviet1.noiDung = "Sau khi quét qua miền Trung Philippines, siêu bão Manyi dự báo sẽ vào Biển Đông và trở thành cơn bão thứ 9 trên khu vực này trong năm 2024.";
        baiviet1.xuatThongTin();

        BaiViet baiviet2 = new BaiViet();
        baiviet2.tieuDe = "Mỹ - Trung nhất trí không để AI ra quyết định về vũ khí hạt nhân";
        baiviet2.hinhAnh = "hinh2.png";
        baiviet2.noiDung = "Tổng thống Mỹ Joe Biden và Chủ tịch Trung Quốc Tập Cận Bình nhất trí không để AI ra quyết định liên quan đến vũ khí hạt nhân, đánh dấu lần đầu trao đổi về vấn đề này.";
        baiviet2.xuatThongTin();

        BaiViet baiviet3 = new BaiViet(baiviet1);
        Console.WriteLine($"Kiểm tra: {baiviet3 == baiviet1}");
        baiviet3.hinhAnh = "hinh3.png";
        Console.WriteLine(baiviet1.hinhAnh);

        BaiViet baiviet4 = new BaiViet(); // tạo vùng nhớ mới
        baiviet4.tieuDe = baiviet1.tieuDe;
        baiviet4.hinhAnh = baiviet1.hinhAnh;
        baiviet4.noiDung = baiviet1.noiDung;
        Console.WriteLine($"Kiểm tra: {baiviet4 == baiviet1}");

        BaiViet baiviet5 = new BaiViet(); // tạo vùng nhớ mới
        Console.WriteLine($"Giá trị mặc định của noiDung là {baiviet5}");
        // defaul value của các biến có kiểu dữ liệu string là null
        // integer là 0
        // bool là 0


        // // Bài tập nhập môn
        // // tạo đối tượng học sinh (họ tên, tuổi, giới tính, email)
        // // Xuất thông tin hoc sinh
        // HocSinh hocsinh1 = new HocSinh();
        // hocsinh1.hoTen = "Dương Thị Thuỳ Linh";
        // hocsinh1.tuoi = 20;
        // hocsinh1.gioiTinh = "Nữ";
        // hocsinh1.email = "linh@gmail.com";
        // hocsinh1.xuatThongTin();

        // HocSinh hocsinh2 = new HocSinh();
        // hocsinh2.nhapThongTin();
        // hocsinh2.xuatThongTin();

        // BTVN thêm
        // B1: tạo 1 đối tượng sản phẩm (mã sp, tên sp, giá bán, số lượng tồn kho)
        // nhập và xuất sản phẩm
        SanPham sp = new SanPham();
        sp.nhapThongTin();
        sp.xuatSanPham();

        // B2: tạo lớp retangle với các thuộc tính
        // length (chiều dài)
        // width (chiều rộng)
        // Và viết các phương thức:
        // nhập thông tin
        // Tính diện tích (area)
        // Tính chu vi (perimeter)
    }
}