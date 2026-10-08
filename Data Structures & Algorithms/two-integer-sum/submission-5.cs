public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> numbersDict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            var currentNumber = nums[i];
            var numberToFind = target - currentNumber;
            if(numbersDict.TryGetValue(numberToFind, out var numberToFindIndex)){
                return new int[] {numberToFindIndex, i};
            }
            numbersDict.Add(currentNumber, i);
        }
        return new int[1];
    }
}
