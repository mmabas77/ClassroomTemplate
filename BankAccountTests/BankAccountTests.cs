using BankAccountApp;

namespace BankAccountTests;

public class BankAccountTests
{
    [Fact]
    [Trait("TestGroup", "Deposit_ShouldIncreaseBalance")]
    public void Deposit_ShouldIncreaseBalance()
    {
        // Arrange
        var account = new BankAccount(1000);

        // Act
        account.Deposit(500);

        // Assert
        Assert.Equal(1500, account.GetBalance());
    }

    [Fact]
    [Trait("TestGroup", "Withdraw_ShouldDecreaseBalance_WhenSufficientFunds")]
    public void Withdraw_ShouldDecreaseBalance_WhenSufficientFunds()
    {
        // Arrange
        var account = new BankAccount(1000);

        // Act
        account.Withdraw(400);

        // Assert
        Assert.Equal(600, account.GetBalance());
    }

    [Fact]
    [Trait("TestGroup", "Withdraw_ShouldNotAllowOverdraft")]
    public void Withdraw_ShouldNotAllowOverdraft()
    {
        // Arrange
        var account = new BankAccount(500);

        // Act
        account.Withdraw(600);

        // Assert
        Assert.Equal(500, account.GetBalance());
    }

    [Fact]
    [Trait("TestGroup", "ConcurrentOperations_ShouldBeThreadSafe")]
    public void ConcurrentOperations_ShouldBeThreadSafe()
    {
        // Arrange
        var account = new BankAccount(1000);
        var threads = new Thread[2];

        threads[0] = new Thread(() =>
        {
            for (int j = 0; j < 1000000; j++)
            {
                account.Deposit(10);
            }
        });
        threads[1] = new Thread(() =>
        {
            for (int j = 0; j < 1000000; j++)
            {
                account.Withdraw(10);
            }
        });


        foreach (var thread in threads)
        {
            thread.Start();
        }

        foreach (var thread in threads)
        {
            thread.Join();
        }

        // Assert
        Assert.Equal(1000, account.GetBalance());
    }
}