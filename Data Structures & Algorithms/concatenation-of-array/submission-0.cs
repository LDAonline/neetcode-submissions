public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var arrayLength = nums.Length;
        int[] ans = new int[arrayLength * 2];
        for (int i = 0; i < nums.Length; i++){
            ans[i] = nums[i];
            ans[i + arrayLength] = nums[i];
        }
        return ans;
    
    }
}