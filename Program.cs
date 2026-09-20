public class Program
{
    public static void Main(string[] args)
    {
        List<Expense> expenses = new List<Expense>();
        Expense expense = new Expense();

        expense.Id = expenses.Count + 1;

        Console.Write("Amount: ");
        expense.Amount = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Description: ");
        expense.Description = Console.ReadLine();

        Console.Write("Category: ");
        expense.Category = Console.ReadLine();

        expense.Date = DateTime.Now;

        expenses.Add(expense);

        foreach (Expense currentExpense in expenses)
        {
            Console.WriteLine($"Id: {currentExpense.Id}");
            Console.WriteLine($"Amount: {currentExpense.Amount}");
            Console.WriteLine($"Description: {currentExpense.Description}");
            Console.WriteLine($"Category: {currentExpense.Category}");
            Console.WriteLine($"Date: {currentExpense.Date}");
        }
    }
}