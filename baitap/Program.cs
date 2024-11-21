internal class Program
{
    private static void Main(string[] args)
    {
        #region bài 1
        List<int> Istnumber = new List<int> { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
        int sum = Bai1.tinhTong(Istnumber);
        Console.WriteLine("Tổng các số trong mảng là: " + sum);
        #endregion

        #region Bài 2
        List<int> lst = new List<int> { 2, 7, 11, 15 };
        int target = 9;
        Console.WriteLine("Bài 2: Tìm 2 số để tồng bằng " + target);
        if (Bai2.twoSum(lst, target) == null)
        {
            Console.WriteLine("không 2 có số có tổng bằng " + target);
        }
        else
        {
            List<int> indexes = Bai2.twoSum(lst, target);
            Console.WriteLine($"chỉ số 2 số có tổng bằng target là: {string.Join(',', indexes)} ");
        }
        #endregion

        #region Bai3
        List<int> numbers = new List<int> { 1, 1, 2, 2, 2, 3, 4, 4, 5 };
        List<int> result = Bai3.reDup(numbers);

        foreach (int n in result)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
        #endregion

        #region Bài 4
        List<int> IstNumbers = new List<int> { 1, 1, 1, 2, 2, 3 };
        int k = 2;

        List<int> results = Bai4.countOccurences(IstNumbers, k);
        #endregion

        #region Bài 5
        List<int> prices = new List<int> { 7, 1, 5, 3, 6, 4 };
        int resultss = Bai5.MaxProfit(prices);
        Console.WriteLine(resultss);
        #endregion
    }
}