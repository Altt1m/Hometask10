class BankAccount
{
    // Properties and Fields
    private string AccountNumber { get; set; }
    private decimal Balance { get; set; }
    private string HolderName { get; set; }

    // Methods
    public BankAccount()
    {
        AccountNumber = "";
        Balance = 0;
        HolderName = string.Empty;
    }

    public BankAccount(string accountNumber, string holderName, decimal balance)
    {
        AccountNumber = accountNumber;
        HolderName = holderName;
        Balance = balance;
    }


    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine("Your account has been replenished for {0:C}", amount);
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine("Your account has been debited {0:C}", amount);
        }
        else
        {
            Console.WriteLine("Not enough funds.");
        }
    }

    public decimal GetBalance()
    {
        return Balance;
    }
}
