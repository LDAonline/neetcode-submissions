public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var maxCount = 0;
        var currentCount = 0;
        foreach(var currentNum in nums){
            currentCount = (currentNum == 1) ? 
                currentCount + 1 : currentCount = 0;
            maxCount = Math.Max(maxCount, currentCount);
        }
        return maxCount;
    }
}