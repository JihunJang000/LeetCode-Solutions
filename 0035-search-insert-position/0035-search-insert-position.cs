public class Solution {
    public int SearchInsert(int[] nums, int target) {
        // 複雑度がLogNなので For文の代わりに binary search 使用
        int left = 0;
        int right = nums.Length - 1;
        int mid;

        while( left <= right ){
            mid = (left + right) / 2;
            
            // nums[mid]が targetより大きい場合は right = mid - 1, 
            // nums[mid]が targetより小さい場合は left = mid + 1,
            // nums[mid] == targetなら midを返却。
            // left > rightになってLoopからぬける場合は Index LeftにTarget入れればOK

            if(nums[mid] == target){
                return mid;
            }
            else if(nums[mid] < target){
                left = mid + 1;
            }
            else if(nums[mid] > target){
                right = mid - 1;
            }




        }

        return left;

    }
}