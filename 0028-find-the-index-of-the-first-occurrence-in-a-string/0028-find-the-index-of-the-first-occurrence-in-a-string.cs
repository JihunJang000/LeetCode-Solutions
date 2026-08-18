public class Solution {
    public int StrStr(string haystack, string needle) {
        int i, k; // i <= k  < i + needle.Length.
        // if needle[0] == haystack[i] -> check if needle  is in haystack.
        bool isTrue = false;
        if(haystack.Length == 1){
            if(haystack[0] == needle[0]){
                return 0;
            }
            else{
                return -1; 
            }
        }

        for(i = 0; i < haystack.Length; i++){
            if(haystack[i] == needle[0]){
                if(needle.Length == 1){
                    return i;    
                }

                for(k = 1; k < needle.Length; k++){
                    // Indexが haystackLengthを超えないように
                    if(i+k >= haystack.Length){
                        break; 
                    }
                    if(needle[k] == haystack[i+k]){
                        if(k == needle.Length - 1){
                            isTrue = true;
                        }
                        continue;
                    }
                    else{
                        break;
                    }
                }
                if(isTrue == true){
                    return i;
                }
                else{
                    continue; 
                }
                
            }
        }

        return -1; 

    }
}