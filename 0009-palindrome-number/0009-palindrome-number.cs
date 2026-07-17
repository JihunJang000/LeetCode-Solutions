public class Solution {

    public bool IsPalindrome(int x) {
        int digit = 0;　// 桁保存用
        List<int> nums = new List<int>(); // 格桁別数字記憶
        
        if(x<0){
            return false;
        }
        
        if(x == 0){
            return true;
        }

        //桁計算＆Listに追加。
        for(long i=10; i<=(long)x*10;i*=10){
            digit+=1;
            
            nums.Add((int)((x % i - x % (i/10)) / (long)Math.Pow(10, digit-1)));
        }
    
            int k = digit / 2;
            for(int i = 0; i<k ;i++){
                if (nums[i] == nums[digit-1-i]){
                    continue;
                }
                else
                    return false; 

            }
            return true;
        

    }
}