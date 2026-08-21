public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // Two pointerを使って解決可能。
        // i = nums1の後ろからのReadIndex, j = nums2の後ろからのReadIndex
        // k = nums1の後ろからのWriteIndex.
        // nums1[i]とnums2[i]を比較して大きい方をnums1[k]えoverWrite, and index-1, k-1.

        // 例外: 1. 比較する値が同じ時、2. nums1[i]を先に使ったとき。
        // 3. 
        int i = m - 1;
        int j = n - 1;
        int k = m + n -1;

        while(i>=0 || j>=0){
            // i=0, j=0例外処理
            if(i == -1){ // j>=0
                nums1[k] = nums2[j];
                k--;
                j--;
                continue;
            }

            if(j == -1){
                break;
            }


            if(nums1[i] > nums2[j]){
                nums1[k] = nums1[i];
                k--;
                i--;
            }
            else if(nums1[i] == nums2[j]){
                nums1[k] = nums1[i];
                nums1[k-1] = nums1[i];
                k = k-2;
                i--;
                j--;
            }
            else{
                nums1[k] = nums2[j];
                k--;
                j--;
            }


        }
    }
}