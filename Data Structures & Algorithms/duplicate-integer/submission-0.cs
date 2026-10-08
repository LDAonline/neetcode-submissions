public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> numberHashset = new HashSet<int>();
        foreach (var number in nums){
            var added = numberHashset.Add(number);
            if (!added){
                return true;
            }
        }
        return false;
    }
}