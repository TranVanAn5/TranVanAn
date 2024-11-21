class Bai3{
    public static List<int> reDup(List<int> numbers){
        List<int> lists = new List<int>();
        lists.Add(numbers[0]);
        for(int i=0; i< numbers.Count; i++){
            if(!lists.Contains(numbers[i])){
                lists.Add(numbers[i]);
            }
        }
        return lists;
    }
}