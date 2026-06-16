# Best Time to Buy and Sell Stock

## NeetCode Problem
**Problem**: Best Time to Buy and Sell Stock (LeetCode 121)

You are given an array `prices` where `prices[i]` is the price of a given stock on the `i`-th day.

You want to maximize your profit by choosing a single day to buy one stock and a different day in the future to sell that stock.

Return the maximum profit you can achieve. If you cannot achieve any profit, return `0`.

**Constraint**: You must buy before you sell.

## Solution
Use a two-pointer sliding window approach. Maintain a left pointer (buy price) and right pointer (current day). For each day, calculate the profit and update the maximum. If the right price is lower than left, move the left pointer to the right position.

## How It Works
1. Initialize `left = 0` (buy day), `right = 1` (sell day), `maxP = 0`
2. While `right` < array length:
   - If `prices[left] < prices[right]`: Calculate profit and update max
   - Else: Update `left = right` (found a new lower price)
   - Increment `right`
3. Return `maxP`

## Example

### Input
```
prices = [7, 1, 5, 3, 6, 4]
```

### Execution
- Day 0: left=7, right=1 → left > right, move left to 1
- Day 1: left=1, right=5 → profit = 4, maxP = 4
- Day 2: left=1, right=3 → profit = 2, maxP = 4
- Day 3: left=1, right=6 → profit = 5, maxP = 5 ✅
- Day 4: left=1, right=4 → profit = 3, maxP = 5

### Output
```
5
```
(Buy at price 1 on day 1, sell at price 6 on day 4)

## Complexity
- **Time**: O(n) — single pass with two pointers
- **Space**: O(1) — only using constant extra space

## Comparison
- Brute Force (nested loops): O(n²) ❌
- Two Pointers: O(n) ✅ (preferred)
