# Valid Palindrome

## NeetCode Problem
**Problem**: Valid Palindrome (LeetCode 125)

Given a string `s`, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

A palindrome reads the same forwards and backwards.

## Solution
Use two pointers (left and right) starting from both ends. Move inward while skipping non-alphanumeric characters. Compare alphanumeric characters (case-insensitive). If all match, it's a palindrome.

## How It Works
1. Initialize left pointer at start, right pointer at end
2. Skip non-alphanumeric characters on both sides
3. Compare characters in lowercase:
   - Mismatch → return false
   - Match → move pointers inward
4. When pointers meet → return true

## Example

### Input
```
s = "A man, a plan, a canal: Panama"
```

### Execution
- Left pointer skips spaces and punctuation
- Right pointer skips spaces and punctuation
- Compare: 'a' vs 'a' ✅, 'm' vs 'm' ✅, 'a' vs 'a' ✅...
- All alphanumeric chars match → true ✅

### Output
```
true
```

## Complexity
- **Time**: O(n) — single pass through string
- **Space**: O(1) — only two pointers

## Comparison
- Brute Force (clean string first): O(n) + extra space ❌
- Two Pointer: O(n) with O(1) space ✅ (preferred)
