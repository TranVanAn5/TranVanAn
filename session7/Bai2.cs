class Bai2
{

    public static List<string> firstIsM(List<string> strings)
    {

        List<string> lists = new List<string>();
        foreach (string str in strings)
        {
            if (str.StartsWith("m"))
            {
                lists.Add(str);
            }
        }
        return lists;
    }
}