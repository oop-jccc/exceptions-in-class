# In-Class Programming Assignment: Validating Coordinates

## Objective

The goal of this exercise is to understand how to validate input parameters in a constructor and throw appropriate exceptions when the validation fails. You'll start with a `Coordinates` class that currently lacks validation for latitude and longitude.

## Starter Code

You are provided with a starter code that includes a `Coordinates` record and some test cases. The `Coordinates` constructor contains `TODO` comments where you'll need to implement validation for latitude and longitude.

```csharp
// TODO: validate latitude, should be between -90 and 90, throw ArgumentException if not
// TODO: validate longitude, should be between -180 and 180, throw ArgumentException if not
```

## Steps

1. **Implement Validation**: In the `Coordinates` constructor, replace the `TODO` comments with code that validates the latitude and longitude. Throw an `ArgumentException` if the validation fails.

2. **Run Tests**: After implementing the validation, run the test cases to make sure that your implementation is correct. The test cases check both valid and invalid coordinates.