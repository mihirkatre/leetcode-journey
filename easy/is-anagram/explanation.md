# Valid Anagram

## Solution
Convert both strings to char arrays, sort them, and compare if they match. Same sorted chars = anagram.

## How It Works
1. Quick check: if lengths differ, not an anagram
2. Sort both character arrays alphabetically
3. Use `SequenceEqual()` to compare sorted arrays element-by-element

## Complexity
- **Time**: O(n log n) — sorting dominates
- **Space**: O(n) — char arrays storage

## Example
"listen" → ['e','i','l','n','s','t'] | "silent" → ['e','i','l','n','s','t'] ✅ Equal
