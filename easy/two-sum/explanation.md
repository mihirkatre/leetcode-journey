# Two Sum

## Solution
Store each number in a dictionary with its index. For each number, check if its complement (target - num) already exists. If yes, return both indices.

## How It Works
1. Calculate complement: `target - current_number`
2. Check if complement is in dictionary
   - Found → return indices
   - Not found → store current number and index
3. Continue until pair found

## Example
nums = [2,7,11,15], target = 9
- i=0, num=2: complement=7 (not found) → store {2: 0}
- i=1, num=7: complement=2 (found at index 0) → return [0, 1] ✅

## Complexity
- **Time**: O(n) — single pass through array
- **Space**: O(n) — dictionary storage

## Comparison
- Brute Force (nested loop): O(n²) ❌
- Hash Map: O(n) ✅ (preferred)
