namespace BankSim;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Bank of Toronto \n");

        BankAccount accountOne = new BankAccount("Eman", "Aziz", "105 Westlodge Avenue, " + "Toronto", "eman467", "password","eman467@gmail.com");

        Console.WriteLine(accountOne + "\n");

        accountOne.DepositIntoChequing(600);

        Console.WriteLine(accountOne);

        string amountWithdrawn = accountOne.WithdrawFromChequing(400);

        Console.WriteLine(amountWithdrawn);
        Console.WriteLine(accountOne);

        string amountWithdrawnTwo = accountOne.WithdrawFromChequing(400);
        Console.WriteLine(amountWithdrawnTwo);
        Console.WriteLine(accountOne);
    }
}