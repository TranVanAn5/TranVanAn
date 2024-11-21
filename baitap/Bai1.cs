class Bai1
{
    public static int tinhTong (List<int> IstNumber)
    {
        int sum = 0;
        for (int i = 0; i < IstNumber.Count; i++)
        {
            sum += IstNumber[i];
        }
        
        return sum;
    }
}