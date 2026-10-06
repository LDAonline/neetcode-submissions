public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int highestCount = 0;
        int currentCount = 0;
        var arrayLength = nums.Length;
        for (int i = 0; i < arrayLength; i++)
        {
            if (nums[i] == 1)
            {
                currentCount++;
            }
            else
            {
                if (currentCount > highestCount){
                    highestCount = currentCount;
                }
                currentCount = 0;
            }

        }
        if (currentCount > highestCount){
            highestCount = currentCount;
            return highestCount;
        }
        return highestCount;
    }
}