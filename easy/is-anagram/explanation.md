# Valid Anagram

## NeetCode Problem
**Problem**: Valid Anagram (LeetCode 242)

Given two strings `s` and `t`, return `true` if `t` is an anagram of `s`, and `false` otherwise.

An anagram is a word or phrase formed by rearranging the letters of another, using all the original letters exactly once.

## Solution
Convert both strings to char arrays, sort them, and compare if they match. Same sorted chars = anagram.

## How It Works
1. Quick check: if lengths differ, not an anagram
2. Sort both character arrays alphabetically
3. Use `SequenceEqual()` to compare sorted arrays element-by-element

## Example

### Input
```
s = "listen"
t = "silent"
```

### Execution
- s length: 6, t length: 6 ✅ (same length)
- s sorted: ['e', 'i', 'l', 'n', 's', 't']
- t sorted: ['e', 'i', 'l', 'n', 's', 't']
- Arrays equal: true ✅

### Output
```
true
```

## Complexity
- **Time**: O(n log n) — sorting dominates
- **Space**: O(n) — char arrays storage

## Comparison
- Brute Force (nested loops): O(n²) ❌
- Sort & Compare: O(n log n) ✅ (preferred)
