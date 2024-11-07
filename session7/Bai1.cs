class Bai1{
public static int tinhTongLonHon50(List<int> numbers){
        int sum = 0;
        
        for(int i=0; i< numbers.Count; i++){
            if(numbers[i] > 50){
                sum += numbers[i];
            }
        }
         return sum;
    }
}