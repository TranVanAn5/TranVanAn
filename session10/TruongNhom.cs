class TruongNhom: NhanVien {
    public string MaQLNhom;
    
    public override double tinhLuong(){
        double luongCoBan = base.tinhLuong();  // kế thừa lại phương thức tinhLuong()
        return luongCoBan + 1.5 * luongCoBan;
    }
}