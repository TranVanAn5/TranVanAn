internal partial class Program
{
    private static void Main(string[] args)
    {
        #region Bài 1: Tính tổng các số lớn hơn 50

        //khai báo list phần tử
        // List<int> numbers = new List<int> { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
        // int sum = Bai1.tinhTongLonHon50(numbers);
        // Console.WriteLine("Tổng các số lớn hơn 50 là: " + sum);
        #endregion

        #region bai3
        
        List<string> strings = new List<string> { "man", "apple", "moon", "cat", "monkey" };
        List<string> result = Bai2.firstIsM(strings);

        Console.WriteLine("Chuỗi bắt đầu bằng 'm':");
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
        #endregion

        #region bai4
        
        // List<int> numbers = new List<int> { 1,1,2,2,2,3,4,4,5};
        // List<int> result =Bai3.reDup(numbers);

        // foreach (int n in result)
        // {
        //     Console.Write(n);
        // }
        #endregion

        #region tìm hiểu về dictionary trong collection
        // Dictionary<string, string> dic= new Dictionary<string, string>();
        // // thêm key-value vaod dic
        // dic.Add("alice", "test");
        // dic["John"] = "Wick";
        // // duyệt dic
        // foreach(KeyValuePair<string, string> pointer in dic){
        //     //pointer: Key-value
        //     Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}"); 
        // }

        // // chỉ duyệt mỗi key hoặc value => giống như list
        // // chỉ duyệt key
        // foreach(string str in dic.Keys){
        //     Console.WriteLine(str);
        // }

        // // update value cho dic
        // dic["alice"] = "Johnson" ;
        // Console.WriteLine("Dic sau khi update:" );
        // foreach(KeyValuePair<string, string>pointer in dic){
        //     Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}"); 
        // }
        // // xóa key-value 
        // dic.Remove("alice");
        // Console.WriteLine("Dic sau khi update:" );
        // foreach(KeyValuePair<string, string>pointer in dic){
        //     Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}"); 
        // }
        #endregion


    }
}