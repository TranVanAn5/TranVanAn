// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nhập Vào số ngày còn lại là: ");
String? ngay = Console.ReadLine();

int day = Convert.ToInt32(ngay);

int soTuan = day / 7;
int soNgay = day % 7;

Console.WriteLine("Còn lại " + soTuan + " Tuần và " +soNgay + " Ngày" );


