namespace BankSim;

public class BankAccount
{
    private double _chequing;
    
    public BankAccount(string firstName, string lastName, string address, string username, string password, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Username = username;
        Password = password;
        Email = email;
        Chequing = 0;
        Savings = 0;
    }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string Username { get; set; }
    
    public string Password { get; set; }
    
    public string Email { get; set; }
    
    public string Address { get; set; }
    
    public double Chequing
    {
        get { return _chequing; }
        private set { _chequing = value; }
    }
    
    public double Savings
    {
        get;
        private set;
    }
    
    public void DepositIntoChequing(double amount)
    {
        Chequing = amount;
    }
    
    public void DepositIntoSavings(double amount)
    {
        Savings = amount;
    }
    
    public string WithdrawFromChequing(double amount)
    {
        if (Chequing - amount >= 0)
        {
            Chequing -= amount;
            return $"Withdrawal of ${amount}";
        }
        else
        {
            return "Insufficient funds for that withdrawal";
        }
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} \nChequing: {Chequing} \nSavings: {Savings}";
    }
}