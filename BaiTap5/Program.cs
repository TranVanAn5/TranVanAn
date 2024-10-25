// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nhập vào số tiền bạn cần đổi (USD): ");
String? tien = Console.ReadLine();

double usd = Convert.ToDouble(tien);

double vnd = usd * 25384;

Console.WriteLine("---------------(1 USD = 25384 VND)------------------" );
Console.WriteLine("Số tiền sau khi được chuyển đổi là (USD to VND): " + vnd +" VND" );