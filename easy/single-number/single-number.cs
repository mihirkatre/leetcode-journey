public class Solution {
    public int SingleNumber(int[] nums) {
        // `res` will hold the XOR accumulation of all numbers.
        // XOR of a number with itself is 0, so pairs cancel out.
        int res = 0;

        // Iterate over every number in the array
        foreach (int num in nums) {
            // XOR the current accumulator with the number.
            // Properties used:
            // - a ^ a = 0
            // - a ^ 0 = a
            // - XOR is commutative and associative
            // After XORing every element, duplicates cancel and only the unique number remains.
            res ^= num;
        }

        // The remaining value in `res` is the single number.
        return res;
    }
}
