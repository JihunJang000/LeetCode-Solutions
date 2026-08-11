public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        // 中腹検査をする為に.Contains()を使う時、時間複雑どを下げる為に HashSet使用。
        HashSet<int> hash = new HashSet<int>();


        // first Inputsを K+1個入れる。
        // kがnums.Length以上の場合はnums.Lengthまで確認.
        for(int i = 0; i <= k && i < nums.Length; i++){
            if(i >= 1){
                if(hash.Contains(nums[i]))
                    return true;
            }

            hash.Add(nums[i]);
        }

        

        // Index k+1以上からは、Hashのウィンドウ範囲から外れた値を削除して 次の値をAddする。
        for(int i=k+1; i<nums.Length; i++){
            hash.Remove(nums[i-(k+1)]);

            if(hash.Contains(nums[i])){
                return true;    
            }
            else{
                hash.Add(nums[i]);
            }
        }

        return false;
    }
}