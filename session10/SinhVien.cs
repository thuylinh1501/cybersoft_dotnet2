class SinhVien : Nguoi{
    public string lop;
    public double diemTB;
    public SinhVien (
        string ID,
        string ten,
        string ngaySinh,
        string gioiTinh,
        string email,
        string lop,
        double diemTB
    ): base(ID, ten, ngaySinh, gioiTinh, email){
        this.lop = lop;
        this.diemTB = diemTB;
    }

    public override void inThongTin(){
        base.inThongTin();
        Console.WriteLine($"ID: {lop}");
        Console.WriteLine($"ID: {diemTB}");
    }
}