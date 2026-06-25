# Single Number

## NeetCode Problem
**Problem**: Single Number (LeetCode 136)

Given a non-empty array of integers `nums`, every element appears twice except for one. Find the element that appears only once.

## Solution
Use bitwise XOR to cancel paired numbers. XOR each element into a running result. Because `a ^ a = 0` and `a ^ 0 = a`, duplicates cancel out and the remaining value is the unique number.

## How It Works
1. Initialize `res = 0`
2. For every number `num` in `nums`, compute `res = res ^ num`
3. Duplicate values cancel each other out because XOR of a number with itself is 0
4. The unique number remains in `res`

## Example

### Input
```
nums = [4, 1, 2, 1, 2]
```

### Execution
- Start: `res = 0`
- XOR 4 → `res = 4`
- XOR 1 → `res = 4 ^ 1`
- XOR 2 → `res = 4 ^ 1 ^ 2`
- XOR 1 → `res = 4 ^ 1 ^ 2 ^ 1` → `1 ^ 1 = 0`, so pairs cancel
- XOR 2 → `res = 4 ^ 2 ^ 2` → `2 ^ 2 = 0`
- Remaining value: `res = 4`

### Output
```
4
```

## Complexity
- **Time**: O(n) — one pass through the array
- **Space**: O(1) — constant extra space

## Why This Works
XOR is commutative and associative, so order does not matter. Each duplicated value appears twice and disappears when XORed together, leaving only the single non-duplicated value.