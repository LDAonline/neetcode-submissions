public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int safeValueFinder = 0; // Where the most recent safe value is
        for (int i = 0; i < nums.Length; i++)
        {
            //When it is not equal the value we want to copy the 
            if (nums[i] != val){
                nums[safeValueFinder] = nums[i];
                safeValueFinder++;
            }
        }
        return safeValueFinder;

    }
}