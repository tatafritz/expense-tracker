public class Program
{
    public static void Main(string[] args)
    {
        bool keepRunning = true;
        ExpenseService expenseService = new ExpenseService();

        while (keepRunning)
        {
            Console.WriteLine("\n==== Expense Tracker ====");
            Console.WriteLine("[1] - Add an expense\n[2] - List all expenses\n[3] - Update an expense\n[4] - Delete an expense\n[0] - Exit");
            Console.Write("Enter an option: ");
            
            int input = Convert.ToInt32(Console.ReadLine());

            Thread.Sleep(2000);

            switch (input)
            {
                case 1:
                    Console.WriteLine("\nAdd Expense:\n");

                    Expense expense = new Expense();

                    Console.Write("Amount: ");
                    expense.Amount = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Description: ");
                    expense.Description = Console.ReadLine();

                    Console.Write("Category: ");
                    expense.Category = Console.ReadLine();

                    expenseService.AddExpense(expense);
                    break;
                case 2:
                    Console.WriteLine("\n================ EXPENSES ================\n");
                    Console.WriteLine(
                        "{0,-4} {1,-12} {2,-18} {3,-15} {4,10}",
                        "ID",
                        "DATE",
                        "DESCRIPTION",
                        "CATEGORY",
                        "AMOUNT"
                    );

                    Console.WriteLine(new string('-', 65));

                    List<Expense> expenses = expenseService.GetExpenses();

                    foreach (Expense currentExpense in expenses)
                    {
                        Console.WriteLine(
                            "{0,-4} {1,-12} {2,-18} {3,-15} {4,10:C}",
                            currentExpense.Id,
                            currentExpense.Date.ToString("dd/MM/yyyy"),
                            currentExpense.Description,
                            currentExpense.Category,
                            currentExpense.Amount
                        );
                    }
                    break;
                case 3:
                    Console.WriteLine("\nUpdate Expense\n");
                    
                    Console.Write("Inform expense ID to be updated: ");
                    int updateId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("New amount: ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("New description: ");
                    string description = Console.ReadLine();

                    Console.Write("New category: ");
                    string category = Console.ReadLine();

                    bool updated = expenseService.UpdateExpense(
                        updateId,
                        amount,
                        description,
                        category
                    );

                    if (updated)
                    {
                        Console.WriteLine("Expense updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("There are no expenses with the informed ID.");
                    }
                    break;
                case 4:
                    Console.WriteLine("\nDelete Expense\n");

                    Console.Write("Inform expense ID to be deleted: ");
                    int deleteId = Convert.ToInt32(Console.ReadLine());

                    bool deleted = expenseService.DeleteExpense(deleteId);

                    if (deleted)
                    {
                        Console.WriteLine("Expense deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("There are no expenses with the informed ID.");
                    }
                    break;
                case 0:
                    Console.WriteLine("\nExiting...");
                    Thread.Sleep(2000);
                    keepRunning = false;
                    break;
            }
        }    
    }
}