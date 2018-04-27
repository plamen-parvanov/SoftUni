public class BankAccount
{
    private string bank;
    private string accountName;
    private decimal accountBalance;

    public BankAccount(string bank, string accountName, decimal accountBalance)
    {
        this.bank = bank;
        this.accountName = accountName;
        this.accountBalance = accountBalance;
    }

    public string Bank
    {
        get { return this.bank; }
    }
    public string AccountName
    {
        get { return this.accountName; }
    }
    public decimal AccountBalance
    {
        get { return this.accountBalance; }
    }

}

