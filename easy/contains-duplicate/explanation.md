# Contains Duplicate

## NeetCode Problem
**Problem**: Contains Duplicate (LeetCode 217)

Given an integer array `nums`, return `true` if any value appears more than once in the array, and return `false` if every element is distinct.

## Solution
A HashSet stores unique elements. If the set size is less than the array length, duplicates exist.

## Why Not Brute Force?
Nested loops (O(n²)) compare every pair—extremely slow. HashSet is O(n) with single pass.

## Example

### Input
```
nums = [1, 2, 3, 1]
```

### Execution
- HashSet after iteration: {1, 2, 3}
- Array length: 4
- HashSet size: 3 (4 ≠ 3) → Duplicates found ✅

### Output
```
true
```

## Complexity
- **Time**: O(n) — iterate array once
- **Space**: O(n) — HashSet storage in worst case

## Comparison
- Brute Force: O(n²) ❌
- HashSet: O(n) ✅ (preferred)