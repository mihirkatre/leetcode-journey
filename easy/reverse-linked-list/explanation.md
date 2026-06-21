# Reverse Linked List

## NeetCode Problem
**Problem**: Reverse Linked List (LeetCode 206)

Given the `head` of a singly linked list, reverse the list, and return the **reversed list**.

## Solution
Use three pointers to reverse the links: `prev` (initially null), `curr` (starting at head), and `temp` (to store the next node). Iterate through the list, reversing the direction of each link before moving forward.

## How It Works
1. Initialize: `prev = null`, `curr = head`
2. While `curr` is not null:
   - Store next node: `temp = curr.next` (preserve the forward link)
   - Reverse current link: `curr.next = prev`
   - Move prev forward: `prev = curr`
   - Move curr forward: `curr = temp`
3. Return `prev` (new head of reversed list)

## Example

### Input
```
head = [1, 2, 3, 4, 5]
```

### Execution
```
Initial: 1 → 2 → 3 → 4 → 5 → null

Step 1: temp=2, 1.next=null, prev=1, curr=2
        null ← 1   2 → 3 → 4 → 5 → null

Step 2: temp=3, 2.next=1, prev=2, curr=3
        null ← 1 ← 2   3 → 4 → 5 → null

Step 3: temp=4, 3.next=2, prev=3, curr=4
        null ← 1 ← 2 ← 3   4 → 5 → null

Step 4: temp=5, 4.next=3, prev=4, curr=5
        null ← 1 ← 2 ← 3 ← 4   5 → null

Step 5: temp=null, 5.next=4, prev=5, curr=null
        null ← 1 ← 2 ← 3 ← 4 ← 5

Loop ends, return prev (5)
```

### Output
```
[5, 4, 3, 2, 1]
```

## Complexity
- **Time**: O(n) — visit each node exactly once
- **Space**: O(1) — only using three pointers (constant extra space)
