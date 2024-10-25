// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nhập vào số phút: ");
String? phut = Console.ReadLine();

int minute = Convert.ToInt32(phut);

int soGio = minute / 60;
int soPhut = minute % 60;

Console.WriteLine("Thời gian của bạn là " + soGio + " Giờ và " + soPhut + " Phút." );