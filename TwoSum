public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++)
        {
            int x = target - nums[i];
            int indexX = Array.IndexOf(nums, x);
            if(indexX > -1 && indexX != i)
                return new int[2] { i, indexX };
        }
        return null;
    }
}
