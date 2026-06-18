public class Solution {
    public bool IsPalindrome(string s){
        //two pointer
        int l = 0;
        int r = s.Length - 1;

        while(l < r){
            //if character on left pointer is not alphanumeric (is space or punctuation), skip it and move ahead.
            if(!IsAlphaNumeric(s[l])){
                l++;
                continue;
            }

            //if character on right pointer is not alphanumeric (is space or punctuation), skip it move behind.
            if(!IsAlphaNumeric(s[r])){
                r--;
                continue;
            }

            //is valid alphanumeric character, compare in lower case
            if(char.ToLower(s[l]) != char.ToLower(s[r])){
                return false;
            }
            l++;
            r--;
        }
        return true;
    }

    //Custom function to determine if character is alphanumeric or not, return true or false.
    public bool IsAlphaNumeric(char c) {
        return ( c >= 'a' && c <= 'z' ||
                 c >= 'A' && c <= 'Z' ||
                 c >= '0' && c <= '9' );
    }
}