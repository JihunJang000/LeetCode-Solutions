public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>(); //開き括弧だけを入れて閉じ括弧が出る時Peekで一致するか比較

        for(int i=0; i<s.Length; i++){
            if(i == 0 && !(s[i] == '(' || s[i] == '[' || s[i] == '{')) // s[0]は開き括弧
                return false;
            else if(i == s.Length-1 && (s[i] == '(' || s[i] == '[' || s[i] == '{')) //最後は閉じ括弧。
            {
                return false;
            }
            else if(s[i] == '(' || s[i] == '[' || s[i] == '{') // s[i]が開き括弧の場合はStackに保存
            {
                stack.Push(s[i]);
            }
            // 閉じ括弧との対応をチェックする前に、Stackが空かどうか確認。
            else if(stack.Count == 0){ 
                return false;
            }
            // 閉じ括弧が出た時は対応する開き括弧がStackのpeekにあるべき
            else if(s[i] == ')'){
                if(stack.Peek() == '('){
                    stack.Pop();
                    continue;
                }
                else{
                    return false;
                }
            }
            else if(s[i] == '}'){
                if(stack.Peek() == '{'){
                    stack.Pop();
                    continue;
                }
                else{
                    return false;
                }
            }
            else if(s[i] == ']'){
                if(stack.Peek() == '['){
                    stack.Pop();
                    continue;
                }
                else{
                    return false;
                }
            }
            else{
                return false;
            }
        }

        // 配列を確認した後 stackに何かある場合(開き括弧)、return false.
        if(stack.Count != 0){
            return false;
        }
        return true;

    }
}