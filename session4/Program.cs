// See https://aka.ms/new-console-template for more information

// while
#region 
// Console.WriteLine("Nhập vào n: ");
// String? n = Console.ReadLine();

// int n1= Convert.ToInt32(n);
// int count = 1;
// while(count <= n1){
//      Console.WriteLine(count);
//      count++;
// }
#endregion
#region tính tổng các số n
// Console.WriteLine("Nhập Vào n: " );
// String? n = Console.ReadLine();

// int number = Convert.ToInt32(n);
// int count = 1;
// int sum = 0;
// while (count <= number){
//     sum += count;
//     count++;
// }
// Console.WriteLine(sum);
#endregion
#region 
// for
// Console.WriteLine("Nhập vào n: ");
// String? number = Console.ReadLine();

// int number1= Convert.ToInt32(n);

// for( int i=1 ; i < n1; i++){
//     Console.WriteLine(i);
// }

// do...while
#endregion
#region tính giai thừa
// Console.WriteLine("Nhập vào n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int count = 1;
// int giaiThua = 1;
// while(count <= n ){
//     giaiThua *= count;
//     count++;
// } 
// Console.WriteLine("giai thừa bằng:  " + giaiThua);
#endregion

#region in bảng cửu chương
// Console.WriteLine("Nhập vào n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int count = 1;
// int cuuChuong = 1;
// Console.WriteLine("Bảng cửu chương của " + n + " là: " );
// while( count <= 10){
//     cuuChuong = count * n;
//     Console.WriteLine(count + " x " + n + " = " + cuuChuong);
//     count++;
// }

#endregion

#region kiểm tra có phải số nguyên tố hay không
// Console.WriteLine("Nhập vào n: ");
// int n = Convert.ToInt32(Console.ReadLine());
 
// int count = 2;

// while(count <= n){
//     if(n % count == 0){
//         Console.WriteLine(n + " không phải Là số nguyên tố");
//         break;
//     }
//     count++;
// }
// if(count == n ){
//  Console.WriteLine(n + " Là số nguyên tố");
// }

// Console.WriteLine("Nhập vào n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int i = 0;
// for( i  = 2; i< n; i++){
//     if(n % i == 0){
//         Console.WriteLine(n + " không phải Là số nguyên tố");
//         break;
//     }
// }
// if( i == n ){
//  Console.WriteLine(n + " Là số nguyên tố");
// }
#endregion

#region for statement
// Console.WriteLine("Nhập vào n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for(int i = 1 ; i <= 10 ; i++){
//     Console.WriteLine(i + " x " + n + " = " + n*i);

// }
#endregion

#region in hình chữ nhật
// Console.WriteLine("Nhập vào chiều dài: ");
// int dai = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Nhập vào chiều rộng: ");
// int rong = Convert.ToInt32(Console.ReadLine());

// for(int i = 0 ; i < rong ; i++){
//     for(int j = 0; j < dai; j ++){
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }
#endregion
#region hình tam giác cân
// Console.Write("Nhập vào chiều cao tam giác: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for(int i=0; i < n ; i++){
//     for(int j = 0 ; j < n - i - 1; j++){
//         Console.Write(" ");
//     }
//     for(int k = 0 ; k < (2 * i + 1); k++){
//         Console.Write("*");
//     } 
//     Console.WriteLine();
// }
#endregion

#region in ra hình chữ nhật rỗng
Console.WriteLine("Nhập vào chiều dài: " );
int dai = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhập vào chiều rộng: ");
int rong = Convert.ToInt32(Console.ReadLine());
int i;
for(i = 0; i < rong ;i++){
    for(int j = 0; j< dai; j++){
        if(i == 0 || i == rong - 1 || j == 0 || j == dai - 1){
            Console.Write("*");
        }else{
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
#endregion