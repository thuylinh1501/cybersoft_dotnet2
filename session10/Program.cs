internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // 4 tính chất trong OOP
        // - Tính kế thừa
        // - Tính đa hình
        // - Tính trừu tượng
        // - Tính đa hình

        // BT mẫu: Trong công ty có 3 đối tượng: nhân viên, trưởng nhóm, quản lý
        // Lập trình quản lý nhân sự trong công ty
        // Nhân viên: mã NV, tên, ngày sinh, tuổi, lương
        // Trưởng nhóm: mã NV, tên, ngày sinh, tuổi, lương, mã quản lý
        // Quản lý: mã NV, tên, ngày sinh, tuổi, lương, mã quản lý
        // Tính lương:  trưởng nhóm
        // TruongNhom truongNhom = new TruongNhom();
        // truongNhom.tenNV = "Nguyen van Teo";
        // Console.WriteLine($"Tên của trưởng nhóm là {truongNhom.tenNV}");

        // phạm vi truy cập của thuộc tính và phương thức
        // public: có thể truy cập từ bất kỳ đâu: class con, bên ngoài
        // private: class con và bên ngoài class không thể truy cập. Chỉ truy cập đc từ chính class đó
        // protected: class con có thể truy cập từ các thuộc tính cha, nhưng ngoài class không thể

        QuanLy quanLy = new QuanLy();
        quanLy.luong = 100000;
        Console.WriteLine($"Lương quản lý {quanLy.tinhLuong()}");
        // Lưu ý override:
        // nếu class con không muốn dùng logic của phương thức cha thì thế viết lại trong class con
        // nếu muốn dùng lại logic class cha thì dùng :  base.tenPhuongThuc() để gọi phhương thức của class cha

        // BT ôn lại
        // Sinh viên, giảng viên, cán bộ trong trường học
        // Viết ct quản lý đối tượng trên
        // class người: ID, tên,ngày sinh, giới tính, email
        // sinh vien: ID, tên,ngày sinh, giới tính, email, lớp, điểm tb
        // giảng viên: ID, tên,ngày sinh, giới tính, email, chuyên ngành, học vị
        // cán bộ: ID, tên,ngày sinh, giới tính, email, chức vị phòng ban

        SinhVien sv = new SinhVien("SV01", "Nguyen Van A", "20/11/19990", "Nam", "vana@gmail.com", "12", 8.5);
        sv.inThongTin();
    }
}