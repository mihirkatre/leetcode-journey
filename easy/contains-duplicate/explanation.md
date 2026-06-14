# Contains Duplicate

## Solution
A HashSet stores unique elements. If the set size is less than the array length, duplicates exist.

## Why Not Brute Force?
Nested loops (O(n²)) compare every pair—extremely slow. HashSet is O(n) with single pass.

## Complexity
- **Time**: O(n) — iterate array once
- **Space**: O(n) — HashSet storage in worst case

## Comparison
- Brute Force: O(n²) ❌
- HashSet: O(n) ✅ (preferred)