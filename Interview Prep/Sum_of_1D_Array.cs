public class Solution {
    public int[] RunningSum(int[] nums) {
       for (int i = 1; i < nums.Length; i++) { //Don't start i at 0 - rather start at 1 as the 0 index does not need to be changed for this program
            nums[i] = nums[i] + nums[i-1];
       } 

       return nums;
    }
}