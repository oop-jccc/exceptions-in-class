namespace AccountsTests;

public class Account
{
    // Common properties for all accounts
}

public class SavingsAccount : Account
{
    public double InterestRate { get; init; } = 0.05; // 5% interest rate
}

public class CheckingAccount : Account
{
    public double InterestRate { get; init; } = 0.02; // 2% interest rate
}

[TestFixture]
public class AccountTests
{
    [Test]
    public void IsOperatorPatternMatching()
    {
        Account account = new SavingsAccount(); // This could be changed to CheckingAccount for testing

        if (account is SavingsAccount savingsAccount)
        {
            Assert.That(savingsAccount.InterestRate, Is.EqualTo(0.05));
        }
        
        if (account is CheckingAccount checkingAccount)
        {
            Assert.That(checkingAccount.InterestRate, Is.EqualTo(0.02));
        }
    }
}