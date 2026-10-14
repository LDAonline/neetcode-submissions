public class Solution {
    public int ScoreOfString(string s) {
        var charArr = s.ToCharArray();
        var total = 0;
        for(int i = 0; i < charArr.Length - 1; i++){
            var firstValue = ((int)charArr[i]);
            var secondValue = ((int)charArr[i + 1]);
            total += Math.Abs(firstValue - secondValue);
        }
        return total;
    }
}