internal class Program
{
    private static void Main(string[] args)
    {
        // 4 tính chất trong OOP
        // - tính kế thừa: class con kế thừa các thuộc tính (biến)và phương thức (hàm) của class cha
        // - tính đóng gói: 
        // - tính trừu tượng
        // - tính đa hình

        //phạm vi try cập của thuộc tính và phương thức
        // public: có thể truy cập từ bất kỳ đâu: class con, bên ngoài class

        // private: class con và bên ngoài ko thể truy cập, chỉ có thể truy cập từ chính class đó
        // protected: class con có thể truy cập các thuộc tính của class cha, nhưng bên ngoài class k thể truy cập đc

        QuanLi quanLi= new QuanLi();
        quanLi.Luong = 10000;
        Console.WriteLine($"Lương của nhân viên là: {quanLi.Luong}");
        //c# check class QuanLy để tìm thuộc tính Lương
        // nếu k có thì check class cha(truongnhom)
        // nếu k có thì check class cha của class cha(nhanvien)

        //Bt ôn lại
        // - sinh viên, giảng viên, cán bộ trong trường
        // viết chương trình quản lí những đối tượng trên
        // class: Nguoi: id, tên, ngày sinh, giới tính, email
        // sinh viên: như tên, lớp , điểm TB
        // giảng viên: như Nguoi, chuyên ngành, học vị
        //cán bộ: như nguoi, chức vụ, phòng ban

        

    }
}