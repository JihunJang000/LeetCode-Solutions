public class Solution {
    public string AddBinary(string a, string b) {
        int aIndex = a.Length - 1;
        int bIndex = b.Length - 1;

        int carry = 0;
        int sum;

        List<int> sumBinary = new List<int>(); // stringに変える前に各桁の値をListに保存。

        // 右側の桁から順番に足し算
        while(aIndex >= 0 || bIndex >= 0 || carry != 0){
            sum = carry;

            // aにまだ桁が残っている場合
            if(aIndex >= 0){
                sum += a[aIndex] - '0';
                aIndex--;
            }

            // bにまだ桁が残っている場合
            if(bIndex >= 0){
                sum += b[bIndex] - '0';
                bIndex--;
            }

            // 現在の桁の値を先頭に追加。
            sumBinary.Insert(0, sum % 2);

            // 次の桁への繰り上がり
            carry = sum / 2;
        }

        string output = "";

        for(int i = 0; i < sumBinary.Count; i++){
            output += sumBinary[i];
        }

        return output;
    }
}