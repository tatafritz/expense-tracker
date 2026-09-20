public class Program
{
    public static void Main(string[] args)
    {
        List<Expense> expenses = new List<Expense>();
        Expense expense = new Expense();

        while (true)
        {
            Console.WriteLine("\n==== Expense Tracker ====");
            Console.WriteLine("[1] - Add an expense\n[2] - List all expenses\n[3] - Update an expense\n[4] - Delete an expense");
            Console.Write("Enter an option: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1){
                Console.WriteLine("\nAdd Expense:\n");
                expense.Id = expenses.Count + 1;

                Console.Write("Amount: ");
                expense.Amount = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Description: ");
                expense.Description = Console.ReadLine();

                Console.Write("Category: ");
                expense.Category = Console.ReadLine();

                expense.Date = DateTime.Now;

                expenses.Add(expense);
            }

            if (input == 2)
            {
                Console.WriteLine("\nExpenses List:\n");
                foreach (Expense currentExpense in expenses)
                {
                    Console.WriteLine($"Id: {currentExpense.Id}");
                    Console.WriteLine($"Amount: {currentExpense.Amount}");
                    Console.WriteLine($"Description: {currentExpense.Description}");
                    Console.WriteLine($"Category: {currentExpense.Category}");
                    Console.WriteLine($"Date: {currentExpense.Date}");
                }
            }

            if (input == 3)
            {
                Console.WriteLine("\nUpdate Expense\n");
                Console.Write("Inform expense ID to be updated: ");
                int updateId = Convert.ToInt32(Console.ReadLine());

                Expense? expenseToUpdate = expenses.FirstOrDefault(e => e.Id == updateId);

                if (expenseToUpdate != null)
                {
                    Console.Write("New amount: ");
                    expenseToUpdate.Amount = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("New description: ");
                    expenseToUpdate.Description = Console.ReadLine();

                    Console.Write("New category: ");
                    expenseToUpdate.Category = Console.ReadLine();

                    Console.WriteLine("Expense updated successfully.");
                }
                else
                {
                    Console.WriteLine("There are no expenses with the informed ID.");
                }
            }
            
            if (input == 4)
            {
                Console.WriteLine("\nDelete Expense\n");
                Console.Write("Inform expense ID to be deleted: ");
                int deleteId = Convert.ToInt32(Console.ReadLine());

                Expense? expenseToDelete = expenses.FirstOrDefault(e => e.Id == deleteId);

                if (expenseToDelete != null)
                {
                    expenses.Remove(expenseToDelete);
                    Console.WriteLine("Expense deleted successfully.");
                }
                else
                {
                    Console.WriteLine("There are no expenses with the informed ID.");
                }
            }

        }    
    }
}