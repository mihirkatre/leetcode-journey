public class Solution{
    public bool IsValidParenthesis(string s){
        //Use stack to store values and match
        Stack<char> stack = new Stack<char>();
        //Use dictionary to match key value pairs of brackets
        Dictionary<char, char> openToClose = new Dictionary<char, char>{
            {'}', '{'},
            {')', '('},
            {']', '['}
        };
        //loop the string
        foreach (char c in s){
            //if the char is an closing bracket
            if(openToClose.ContainsKey(c)){
                //if the stack is not empty and stack value is equal to dictionary value
                if(stack.Count > 0 && stack.Peek() == openToClose[c]){
                    //empty the stack top
                    stack.Pop();
                }
                else{
                    //value mismatch, return false, invalid brackets
                    return False;
                }
            }
            //if the char is an opening bracket
            else{
                stack.Push(c);
            }
        }
        //if everything matched, stack will be empty
        return stack.Count == 0;
    }
}