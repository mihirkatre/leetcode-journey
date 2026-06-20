public class Solution{
    public int Search(int[] nums, int target){
        int l = 0;
        int r = nums.Length - 1;

        while (l < r){
            int m = (l + r) / 2;
            if(nums[m] < target){
                l = m + 1;
            }
            else{
                r = m;
            }
        }
        return (l < nums.Length && nums[l] == target) ? l : -1;
    }
}