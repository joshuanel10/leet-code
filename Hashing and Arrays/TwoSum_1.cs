//Brute Force Method

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) {
                    return new int[] { i, j };
                }
            }
        }
        throw new ArgumentException("No Solution Found");
    }
}

//Efficient Method
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            
            if (numToIndex.ContainsKey(complement)) {
                return new int[] { numToIndex[complement], i };
            }
            
            numToIndex[nums[i]] = i; // Store the current number and its index in the Dictionary
        }
        
        throw new ArgumentException("No solution found");
    }
}
