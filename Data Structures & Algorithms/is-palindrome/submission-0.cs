public class Solution {
    public bool IsPalindrome(string s) {
        var myString = s.Trim();
        Regex rgx = new Regex("[^a-zA-Z0-9]");
        var str = rgx.Replace(myString, "");
        var stringCharArray = str.ToLower().ToCharArray();
        var endPointer = stringCharArray.Length - 1;
        for (int startPointer = 0; startPointer < stringCharArray.Length; startPointer++){
            if (stringCharArray[startPointer] != stringCharArray[endPointer]){
                return false;
            }
            endPointer--;
        }
        return true;
    }
}
