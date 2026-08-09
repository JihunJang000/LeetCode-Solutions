public class Solution {
    public int RomanToInt(string s) {
        // Dictionaryで文字に該当する整数を保存。
        Dictionary<char, int> charToInt = new Dictionary<char, int>();
        char c;
        int sum = 0;
        // 文字を順番に読んで文字に該当する値を追加し続きながら、
        // もしも次の値が大きい場合はその値は引く。
        
        charToInt['I'] = 1;
        charToInt['V'] = 5;
        charToInt['X'] = 10;
        charToInt['L'] = 50;
        charToInt['C'] = 100;
        charToInt['D'] = 500;
        charToInt['M'] = 1000;



        for(int i = 0; i < s.Length ; i++){
            
            // i+1例外処理
            if(i != s.Length-1){
                if(charToInt[s[i]] < charToInt[s[i + 1]]){  
                    sum -= charToInt[s[i]];
                    continue;
                }
            }
            
            
            sum +=charToInt[s[i]];
            
        }

        return sum;
    }
}