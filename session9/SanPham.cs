class SanPham
{
    public string maSP;
    public string tenSP;
    public double giaBan; 
    public int soLuong; 

    public void nhapThongTin()
    {
        Console.WriteLine("Mời nhập mã sản phẩm:");
        maSP = Console.ReadLine();

        Console.WriteLine("Mời nhập tên sản phẩm:");
        tenSP = Console.ReadLine();

        Console.WriteLine("Mời nhập giá bán sản phẩm:");
        giaBan = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("Mời nhập số lượng tồn kho:");
        soLuong = Convert.ToInt32(Console.ReadLine()); 
    }

    public void xuatSanPham()
    {
        Console.WriteLine("Thông tin sản phẩm:");
        Console.WriteLine($"- Mã sản phẩm: {maSP}");
        Console.WriteLine($"- Tên sản phẩm: {tenSP}");
        Console.WriteLine($"- Giá bán: {giaBan}"); 
        Console.WriteLine($"- Số lượng tồn kho: {soLuong}");
    }
}