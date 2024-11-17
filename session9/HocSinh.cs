class HocSinh{
    public string hoTen;
    public int tuoi;
    public string gioiTinh;
    public string email;
    public void xuatThongTin(){
        Console.WriteLine("Thông tin học sinh là:");
        Console.WriteLine($"Họ tên: {hoTen}");
        Console.WriteLine($"Tuổi: {tuoi}");
        Console.WriteLine($"Giới tính: {gioiTinh}");
        Console.WriteLine($"Email: {email}");
    }
    public void nhapThongTin(){
        Console.WriteLine("Mời bạn nhập thông tin học sinh:");
        Console.WriteLine("Nhập họ tên:");
        hoTen = Console.ReadLine();
        Console.WriteLine("Nhập tuổi:");
        tuoi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập giới tính:");
        gioiTinh = Console.ReadLine();
        Console.WriteLine("Nhập email:");
        email = Console.ReadLine();
    }
}