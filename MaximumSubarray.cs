public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = int.MinValue;

        for(int start = 0; start < nums.Length; start++)  {
            int sum = nums[start];
            maxSum = maxSum < sum ? sum : maxSum;
            
            for(int window = start + 1; window < nums.Length; window++) {
                sum += nums[window];
                maxSum = maxSum < sum ? sum : maxSum;
            }
        }
        
        return maxSum;
    }
}
