class TruongNhom: NhanVien{
    public string maTN;
    public string getMaNV(){
        return this.maNV;
    }
    public override double tinhLuong(){
        double luongCoBan = base.tinhLuong();
        return luongCoBan + 1.5*luongCoBan;
    }
}