class NhanVien{
    public string maNV;
    private string tenNV {get; set;} // mục đích dùng getter và setter để truy cập vào thuộc tính private
    public string ngaySinh;
    public int tuoi;
    public double luong;
    public string gioiTinh;

    // overload: nạp chồng phương thức
    // override: ghi đè trong lớp
    public virtual double tinhLuong(){
        return 1000;
    }
}