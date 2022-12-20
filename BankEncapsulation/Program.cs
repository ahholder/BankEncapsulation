namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string input = "";
            double placeholder;
            double transaction = 0;
            var account = new BankAccount();
            Console.Write("Deposited Amount: ");
            input = Console.ReadLine();
            if (input != null && double.TryParse(input, out placeholder) == true)
            {
                transaction = double.Parse(input);
            }
            Console.WriteLine("You added $" + transaction + " to your account.");
            account.Deposit(transaction);
            //double balanced = account.GetBalance();
            //Console.WriteLine("");
            Console.Write("Your balance is now $");
            account.GetBalance();
            Console.Write(".");
            Console.WriteLine("");
        }
    }
}
