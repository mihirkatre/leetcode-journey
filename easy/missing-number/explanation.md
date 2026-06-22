# Missing Number

## NeetCode Problem
**Problem**: Missing Number (LeetCode 268)

Given an array `nums` containing `n` integers in the range `[0, n]` without any duplicates, return the single number in the range that is missing from `nums`.

**Follow-up**: Could you implement a solution using only `O(1)` extra space complexity and `O(n)` runtime complexity?

## Solution
Use a mathematical approach based on the difference between expected sum and actual sum. Initialize result with `n`, then iterate through the array adding each index and subtracting each value. The final result equals the missing number because: **Missing = Expected Sum - Actual Sum**.

## How It Works
1. Initialize `result = n` (accounts for the upper bound of range [0, n])
2. For each index `i` from 0 to n-1:
   - Add `i` (accumulates 0 + 1 + 2 + ... + (n-1))
   - Subtract `nums[i]` (removes each actual value)
3. The equation becomes: `n + (sum of indices) - (sum of array values)`
   - This equals: `n + (0+1+...+(n-1)) - (actual sum)`
   - Which is: `expected_sum - actual_sum = missing_number`
4. Return `result`

## Example

### Input 1
```
nums = [1, 2, 3]
```

### Execution 1
```
n = 3 (array length)
Expected sum: 0 + 1 + 2 + 3 = 6
Actual sum: 1 + 2 + 3 = 6

Walkthrough:
result = 3
i=0: result += 0 - 1 = 2
i=1: result += 1 - 2 = 1
i=2: result += 2 - 3 = 0 ✅
```

### Output 1
```
0
```
(The missing number is 0)

### Input 2
```
nums = [0, 2]
```

### Execution 2
```
n = 2 (array length)
Expected sum: 0 + 1 + 2 = 3
Actual sum: 0 + 2 = 2

Walkthrough:
result = 2
i=0: result += 0 - 0 = 2
i=1: result += 1 - 2 = 1 ✅
```

### Output 2
```
1
```
(The missing number is 1)

## Complexity
- **Time**: O(n) — single pass through array
- **Space**: O(1) — only using one integer variable (meets follow-up requirement!)

## Why This Works
The key insight is that we can avoid storing extra data or sorting by using mathematics. The difference between what we expect (0 through n) and what we have (all but one number) directly gives us the missing number. This is elegant and optimal!
