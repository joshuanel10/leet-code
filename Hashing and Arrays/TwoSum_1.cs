public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    
    //List<int> output = new List<int>();
    HashSet<int> myhash1 = new HashSet<int>();
    bool check;
    

        for (int i = 0; i < nums.Length; i++) {
            
            for (int j = 1; j < nums.Length; j++) {
                if ((nums[i] + nums[j]) == target) {
                    myhash1.Add(i);
                    myhash1.Add(j);
                    
                }
            }
        }
    
        
    List<int> output= myhash1.ToList();    
    int[] intPut = output.ToArray();
    

    return intPut;
}
}
