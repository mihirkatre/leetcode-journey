# Binary Search

## NeetCode Problem
**Problem**: Binary Search (LeetCode 704)

Given an array of integers `nums` which is sorted in ascending order, and an integer `target`, write a function to search `target` in `nums`.

If `target` exists, return its index. Otherwise, return `-1`.

You must write an algorithm with O(log n) runtime complexity.

## Solution
Use two pointers (left and right) to narrow down the search space by half in each iteration. Calculate the midpoint and compare it with the target:
- If mid < target: move left pointer to mid + 1
- If mid >= target: move right pointer to mid
- Continue until left and right pointers meet

## How It Works
1. Initialize `l = 0` (left), `r = nums.Length - 1` (right)
2. While `l < r`:
   - Calculate midpoint: `m = (l + r) / 2`
   - If `nums[m] < target`: move `l = m + 1` (target is on the right)
   - Else: move `r = m` (target is on the left or equals mid)
3. Check if `nums[l] == target`:
   - Found → return `l`
   - Not found → return `-1`

## Example

### Input
```
nums = [−1, 0, 3, 5, 9, 12]
target = 9
```

### Execution
- Iteration 1: l=0, r=5, m=2 → nums[2]=3 < 9 → l=3
- Iteration 2: l=3, r=5, m=4 → nums[4]=9 >= 9 → r=4
- Iteration 3: l=3, r=4, m=3 → nums[3]=5 < 9 → l=4
- Loop ends: l=4, r=4 → nums[4]=9 == 9 ✅

### Output
```
4
```
(Target 9 found at index 4)

## Complexity
- **Time**: O(log n) — search space is halved in each iteration
- **Space**: O(1) — only using constant extra space

## Comparison
- Linear Search: O(n) ❌
- Binary Search: O(log n) ✅ (preferred for sorted arrays)
