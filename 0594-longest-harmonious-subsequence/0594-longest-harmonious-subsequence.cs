public class Solution {
    public int FindLHS(int[] nums) {
        // numsから 部分列を探す問題なのでDictionaryを利用してKey:Value を nums[i]:Countにして
        // iごとに長さをCheckしてMaxLengthを更新。


        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        List<int> savedI = new List<int>();
        // Dictionaryを完成。
        for(int i =0; i<nums.Length; i++){
            if(dictionary.ContainsKey(nums[i]) == true){
                dictionary[nums[i]]++;
                
            }
            else{
                dictionary[nums[i]] = 1; 
                savedI.Add(i);
            }
        }

        int maxLength = 0;

        // key = savedI[i] 
        for(int k=0; k < savedI.Count; k++){
            // key: nums[i]に対してnums[i] + 1がいるかをCheck。
            if(dictionary.ContainsKey(nums[savedI[k]] + 1)){
                if(maxLength < dictionary[nums[savedI[k]]] + dictionary[nums[savedI[k]] + 1]){
                    maxLength = dictionary[nums[savedI[k]]] + dictionary[nums[savedI[k]] + 1];
                }
            }
        }

        return maxLength;
    }
}