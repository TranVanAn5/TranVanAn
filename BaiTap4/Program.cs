// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nhập vào số tiền gốc: ");
String? tien = Console.ReadLine();
Console.WriteLine("nhập vào phí VAT: " );
String? vat = Console.ReadLine();

double tienGoc = Convert.ToDouble(tien);
int phiVAT = Convert.ToInt32(vat);

double tienPhi = tienGoc * phiVAT / 100;
double tongTien = tienGoc + tienPhi;

Console.WriteLine("Tổng số tiền sau phí là: " + tongTien);