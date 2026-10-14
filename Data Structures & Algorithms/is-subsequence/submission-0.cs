public class Solution {
    public bool IsSubsequence(string s, string t) {
        var originalString = s;
        var newString = t;
        var finderIndex = 0;
        for (int i = 0; i < originalString.Length; i++)
        {
            while (finderIndex < newString.Length && originalString[i] != newString[finderIndex])
            {
                finderIndex++;
            }
            // if the index comes to be greater than the length of the new string then it cannot be
            if (finderIndex == newString.Length){
                return false;
            }
            finderIndex++;
        }
        return true;
    }
}