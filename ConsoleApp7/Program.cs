
//Task 1


Console.WriteLine("Welcome to the Basic Banking Application \r\n--------------------------------------");
var user = new User();
Console.WriteLine("Account setup successful !\n");


do
{
    

    if (choice.Deposit)
    {
        Console.Write("Enter deposit amount: ");
        user.Deposit();
        Console.WriteLine("Deposit successful!");
    }


    else if (choice.Withdraw)
    {
        Console.Write("Enter withdrawal amount: ");
        double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
        if (withdrawalAmount > balance)
        {
            Console.WriteLine("Insufficient funds!");
        }
        else
        {
            balance -= withdrawalAmount;
            Console.WriteLine("Withdrawal successful!");
        }
    }

    else if (choice.ViewBalance)
    {
        Console.WriteLine($"Your balance: {balance}");
    }

    else if (choice.Exit)
    {
        Console.WriteLine("Thank you for banking with us. Goodbye!");

    }


    choice = DisplayMenu();

} while (choice.Quiet);
    
int DisplayMenu()
{
    Console.WriteLine("Main Menu:\r\n1.Deposit\r\n2.Withdraw\r\n3.View Balance\r\n4.Exit\r\nPlease select an option:");


    var option = int.Parse(Console.ReadLine());

     
}

enum choice
{
    Deposit,
    Withdraw,
    ViewBalance,
    Exit
}
public class User
{
    private decimal transaction = 0;
    public string Name { get; set; }

    public decimal BalanceAmount { get; set; }

    public int AccountNumber { get; set; }

    public User() //constructor
    {
        Console.WriteLine("Write your name");
        Name = Console.ReadLine();

        Console.WriteLine("Write your account Number");
        AccountNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Write your account Balance");
        BalanceAmount = decimal.Parse(Console.ReadLine());
    }


    public void Deposit(double amount)
    {
        BalanceAmount += amount;
        transactions[transaction++] = amount;
    }

    public void Withdraw(double amount)
    {
        BalanceAmount -= amount;
        transactions[transaction--] = amount;
    }




}

public class BankAccount
{
    BankAccount(string name, int id, decimal intialBalance)
    {
        Name = name;
        Id = id;
        IntialBalance = intialBalance;
    }
    public string Name { get; set; }
    public int Id { get; set; }
    public decimal IntialBalance { get; set; }
    public List<decimal> transaction { get; set; }

    public void Deposit(decimal amount)
    {
        transaction.Add(amount);
    }
    public void Withdraw(decimal amount)
    {
        transaction.Add(amount* -1);
    }

    public decimal GetAllDeposit()
    {
        return transaction(r => r> 0).Sum();
    }

    public decimal GetAllWithdraw()
    {
        return transaction(r => r < 0).Sum();
    }

    public decimal GetBalance()
    {
        return intialBalance + transaction.Sum();
    } 

}








