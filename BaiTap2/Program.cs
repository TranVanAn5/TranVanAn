// See https://aka.ms/new-console-template for more information

//input
Console.WriteLine("Nhập vào giá tiền của sản phẩm: ");
String? price = Console.ReadLine();
Console.WriteLine("nhập voucher của sản phẩm: " );
String? discount = Console.ReadLine();

//output
int tienGiam;
int tienTra;

//process
int formatPrice = Convert.ToInt32(price);
int formatDiscount = Convert.ToInt32(discount);
tienGiam = formatPrice * formatDiscount/100;
tienTra = formatPrice - tienGiam;

Console.WriteLine("số tiền phải trả là: " + tienTra);
