public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int startPointer = 0;
        for (int endPointer = numbers.Length - 1; endPointer > 0; endPointer--)
        {
            while (startPointer != endPointer)
            {
                if (numbers[endPointer] + numbers[startPointer] > target)
                {
                    break;
                }
                if (numbers[endPointer] + numbers[startPointer] == target){
                    return new int[] { ++startPointer, ++endPointer };
                }
                
                startPointer++;

            }
        }
        return new int[1];
    }
}
