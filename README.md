# In-Class Programming Assignment: Pattern Matching with Account Types

## Objective

The goal of this exercise is to understand how to use the `is` operator for pattern matching in C# with inheritance hierarchies. You'll work with an `Account` base class and its derived classes (`SavingsAccount` and `CheckingAccount`) to practice pattern matching techniques.

## Starter Code

You are provided with a starter code that includes an `Account` base class and two derived classes: `SavingsAccount` and `CheckingAccount`. Each account type has different interest rates:

- `SavingsAccount`: 5% interest rate (0.05)
- `CheckingAccount`: 2% interest rate (0.02)

The test class contains an example of pattern matching using the `is` operator with `SavingsAccount`, and includes a `TODO` comment where you'll need to implement a similar test for `CheckingAccount`.

```csharp
// TODO: Create a test for CheckingAccount using the same pattern matching technique
```

## Steps

1. **Implement Pattern Matching Test**: In the `AccountTests` class, add a test method that uses the `is` operator to check if an `Account` instance is a `CheckingAccount` and verify its interest rate.

2. **Run Tests**: After implementing the test, run the test cases to make sure that your pattern matching implementation works correctly for both account types.