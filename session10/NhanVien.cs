class NhanVien{
     public string  MaNV;
     public string Name;
     public string NgaySinh;
     public int Tuoi;
     public string GioiTinh;
     public double Luong;

     public virtual double tinhLuong(){
          return 1000;
     }
     
}