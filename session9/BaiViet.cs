class BaiViet{
    public string tieuDe;
    public string noiDung;
    public string hinhAnh;
    private BaiViet baiviet1;

    //default khi khởi tạo đối tượng thì C# sẽ gọi hàm khởi tạo (constructor) mặc định
    // hàm khởi tạo này sẽ tạo giá trị mặc định cho các thuộc tính
    // cú pháp: <tên class>(){}
    public BaiViet(){
        Console.WriteLine("Đây là hàm khởi tạo");
    } // khởi tạo hàm constructor

    // có 2 loại hàm constructor: có tham số và không tham số
    // Lưu ý: Trong class chỉ có 1 trong 2 constructor xuất hiện
    public BaiViet(string tieuDe, string noiDung, string hinhAnh){
        this.tieuDe = tieuDe;
        this.hinhAnh = hinhAnh;
        this.noiDung = noiDung;
    } 

    public BaiViet(BaiViet other)
{
    this.tieuDe = other.tieuDe;
    this.noiDung = other.noiDung;
    this.hinhAnh = other.hinhAnh;
}

    public void xuatThongTin(){
        Console.WriteLine("Thông tin bài viết là:");
        Console.WriteLine($"Tiêu đề: {tieuDe}");
        Console.WriteLine($"Nội dung: {noiDung}");
        Console.WriteLine($"Hình ảnh: {hinhAnh}");
    }
}