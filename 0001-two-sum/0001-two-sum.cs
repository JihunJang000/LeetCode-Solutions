public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // nums[i] + nums[j] = targetである i, jをNested For文で探す
        int[] result = new int[2];
        
        for(int i=0; i<nums.Length; i++)
        {
            for(int j=i+1; j<nums.Length; j++)
            {
                if(nums[i] + nums[j] == target){
                    
                    result[0] = i;
                    result[1] = j;
                    
                    return result;
                }
            }
        }

        Console.WriteLine("該当するOutputがいません");
        return　result;
    }
}