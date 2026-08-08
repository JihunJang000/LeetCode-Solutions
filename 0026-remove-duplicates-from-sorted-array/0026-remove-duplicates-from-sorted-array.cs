public class Solution {
    public int RemoveDuplicates(int[] nums) {
        // In-Place: 重複した値をその配列を変えて重複を削除。-> 　Two Pointers

        if(nums.Length <= 1) return nums.Length; 

        int writeIndex = 1;
        // writeIndex = 1, readIndex = 1から始めて、readIndexが以前Indexの値と違う場合、
        // readIndexに入っている値を writeIndexに入れる方法。
        for(int readIndex = 1; readIndex<nums.Length; readIndex++){
            if(nums[readIndex] != nums[readIndex - 1]){
                nums[writeIndex] = nums[readIndex];

                writeIndex++;
            }
            
        }

        return writeIndex;        
    }         
}