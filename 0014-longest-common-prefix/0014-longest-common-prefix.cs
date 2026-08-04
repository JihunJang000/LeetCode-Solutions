public class Solution {
    public string LongestCommonPrefix(string[] strs) {
    
        if(strs == null){
            return "";
        }

        string prefix ="";
        int repeatCount = 0;
        int sameCount = 0;

        
        if(strs[0] == null || strs[0] == ""){
             return "";
          }

        prefix = strs[0]; 
            

        for(int i=0; i<strs.Length-1; i++){ 
            
            

            if(prefix.Length >= strs[i+1].Length){
                repeatCount = strs[i+1].Length;
            }
            else
            {
                repeatCount = prefix.Length;
            }
            
            

            for(int j=0;j<repeatCount;j++){
                if(prefix[j] == strs[i+1][j]){
                    sameCount++;
                }
                else
                    break;
            }
            prefix = strs[i+1].Substring(0, sameCount);
            
            sameCount =0;

        }

        return prefix; 
        
    }
}