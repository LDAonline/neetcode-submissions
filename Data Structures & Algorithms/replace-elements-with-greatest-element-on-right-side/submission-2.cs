public class Solution 
{
    public int[] ReplaceElements(int[] arr) 
    {
        int arrayLength = arr.Length;
        int[] answer = new int[arrayLength];
        int rightMax = -1;

        for (int i = arrayLength - 1; i >= 0; i--) 
        {
            answer[i] = rightMax;
            rightMax = Math.Max(arr[i], rightMax);
        }
        return answer;
    }
}