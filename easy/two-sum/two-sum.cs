public class Solution{
    public int[] TwoSum(int[] nums, int target){
        
        Dictionary<int, int> prevValue = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++){
            var diff = target - nums[i];
            if(prevValue.ContainsKey(diff)){
                return new int[] {prevValue[diff], i};
            }
            prevValue[nums[i]] = i;
        }

        return new int[] {};
    }
}