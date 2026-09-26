public class Program
{
    public static void Main(string[] args)
    {
        bool keepRunning = true;
        InputHelper input = new InputHelper();
        ExpenseService expenseService = new ExpenseService();

        while (keepRunning)
        {
            Console.WriteLine("\n==== Expense Tracker ====");
            Console.WriteLine("[1] - Add an expense\n[2] - List all expenses\n[3] - Update an expense\n[4] - Delete an expense\n[5] - Exit");
            
            int menuOption = input.IntInput("Enter a number: ");

            Thread.Sleep(2000);

            switch (menuOption)
            {
                case 1:
                    Console.WriteLine("\nAdd Expense:\n");

                    Expense expense = new Expense();
                    expense.Amount = input.DecimalInput("Amount: ");

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
                    
                    int updateId = input.IntInput("Inform expense ID to be updated: ");

                    Expense? expenseToUpdate = expenseService.GetExpenseById(updateId);

                    if (expenseToUpdate == null)
                    {
                        Console.WriteLine("There are no expenses with the informed ID.");
                        break;
                    }

                    decimal amount = input.DecimalInput("New amount: ");

                    Console.Write("New description: ");
                    string description = Console.ReadLine();

                    Console.Write("New category: ");
                    string category = Console.ReadLine();

                    expenseService.UpdateExpense(
                        updateId,
                        amount,
                        description,
                        category
                    );

                    Console.WriteLine("Expense updated successfully.");
                    break;
                case 4:
                    Console.WriteLine("\nDelete Expense\n");

                    int deleteId = input.IntInput("Inform expense ID to be deleted: ");

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
                case 5:
                    Console.WriteLine("\nExiting...");
                    Thread.Sleep(2000);
                    keepRunning = false;
                    break;
            }
        }    
    }
}