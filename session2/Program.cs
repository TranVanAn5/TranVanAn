// See https://aka.ms/new-console-template for more information
#region phep toan

/*Console.WriteLine("Hello, World!");

int add = 5 + 10;
Console.WriteLine($"Ket qua cong hai so 5 va 10 la: {add}");

int minus = 10 - 5;
Console.WriteLine($"Kết quả của trừ 2 số là: {minus}");

double nhan = 5 * 10;
Console.WriteLine("Ket qua cua nhan hai so la: "+nhan);

double dev = 10/5;
Console.WriteLine("chia 2 so: "+dev);

float dev2= 25%3;
Console.WriteLine("chia lay du: "+dev2);*/
#endregion
#region toan tu 
/*int cong = 0;
cong += 10;
Console.WriteLine("cong ++: "+ cong);*/
#endregion
#region ep kieu du lieu c1: dung convert
// convert
// nhap du lieu tu ban phim => ReadLine(String)
// Console.WriteLine("Number: ");
// string? number = Console.ReadLine();

// int convertNumber = Convert.ToInt32(number);
// int sum = convertNumber +1;
// Console.WriteLine($"value number: {sum}");
#endregion
#region tinh chi so BMI
//input 
// chieu cao va can nang duoc nhap tu ban phim\
// Console.WriteLine("Nhap vao chieu cao(m): ");
// string? chieuCao= Console.ReadLine();

// double fChieuCao= Convert.ToDouble(chieuCao);

// Console.WriteLine("nhap vao can nang(kg):");
// string? canNang= Console.ReadLine();
// double fCanNang= Convert.ToDouble(canNang);


//output
// tinh va in ra chi so BMI
// double bmi = 0.0;


//process
//BMI = can nang / chieu cao^2

// bmi = fCanNang /(fChieuCao*fChieuCao);
// Console.WriteLine("chi so BMI la: "+bmi);

#endregion
#region  chu vi dien tinh hinh tron
//input
//  r
Console.WriteLine("nhap vao ban kinh hinh tron: ");
string? banKinh = Console.ReadLine();

double r = Convert.ToDouble(banKinh);

//output
double chuVi = 0;
double dienTich = 0;

// process
double pi = Math.PI;

chuVi = 2*pi*r;
dienTich = pi*r*r;

Console.WriteLine("Chu vi hinh tron la: "+ chuVi);
Console.WriteLine("dien tich hinh tron la: "+ dienTich);
#endregion