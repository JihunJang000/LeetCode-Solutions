public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int index = 0;
        // numsから valと違う値を探すと、nums[Index]にvalを入れて、 Index++;する。
        // valを探した場合は、次の順序(i+1)を探索する。

        for(int i=0; i<nums.Length; i++){
            if(nums[i] != val){
                nums[index] = nums[i]; 
                index++;
            }
            else if(nums[i] == val){
                continue;
            }
        }

        return index;
    }
}