# Valid Parentheses

## NeetCode Problem
**Problem**: Valid Parentheses (LeetCode 20)

Given a string `s` containing just the characters `'('`, `')'`, `'{'`, `'}'`, `'['` and `']'`, determine if the input string is valid.

An input string is valid if:
1. Open brackets are closed by the same type of brackets
2. Open brackets are closed in the correct order

## Solution
Use a Stack to track opening brackets. For each closing bracket, verify it matches the most recent opening bracket. If all brackets match and stack is empty at the end, the string is valid.

## How It Works
1. Create a dictionary mapping closing brackets to their corresponding opening brackets
2. Iterate through each character in the string
3. If character is a closing bracket:
   - Check if stack is not empty and top matches the opening bracket
   - If match → pop from stack
   - If no match → return false (invalid)
4. If character is an opening bracket → push to stack
5. Return true only if stack is empty (all brackets matched)

## Example

### Input 1 (Valid)
```
s = "([{}])"
```

### Execution
- '(' → push to stack: ['(']
- '[' → push to stack: ['(', '[']
- '{' → push to stack: ['(', '[', '{']
- '}' → matches '{' (top of stack) → pop: ['(', '[']
- ']' → matches '[' (top of stack) → pop: ['(']
- ')' → matches '(' (top of stack) → pop: []
- Stack empty → return true ✅

### Input 2 (Invalid)
```
s = "([)]"
```

### Execution
- '(' → push to stack: ['(']
- '[' → push to stack: ['(', '[']
- ')' → expects ']' but got ')', stack top is '[' → return false ❌

### Output
```
true (for Input 1)
false (for Input 2)
```

## Complexity
- **Time**: O(n) — single pass through string
- **Space**: O(n) — stack storage in worst case (all opening brackets)

## Comparison
- Brute Force (try all combinations): O(n!) ❌
- Stack: O(n) ✅ (preferred)
