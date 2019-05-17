public class Solution {
    public void MoveZeroes(int[] nums) {
        for(int current = 0; current < nums.Length; current++) {
            if(nums[current] == 0) {
                for(int next = current + 1; next < nums.Length; next++) {
                    if(nums[next] != 0) {
                        int num = nums[next];
                        nums[next] = 0;
                        nums[current] = num;
                        break;
                    }
                    if(next == nums.Length)
                        return;
                }
            }
        }
    }
}
