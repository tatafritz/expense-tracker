public class ExpenseService
{
    private readonly List<Expense> _expenses = new List<Expense>();
    public void AddExpense(Expense expense)
    {
        expense.Id = _expenses.Count + 1;
        expense.Date = DateTime.Now;

        _expenses.Add(expense);
    }

    public List<Expense> GetExpenses()
    {
        return _expenses;
    }

    public Expense? GetExpenseById(int id)
    {
        return _expenses.FirstOrDefault(e => e.Id == id);
    }

    public bool UpdateExpense(int id, decimal amount, string description, string category)
    {
        Expense? expense = GetExpenseById(id);

        if (expense == null)
            return false;

        expense.Amount = amount;
        expense.Description = description;
        expense.Category = category;

        return true;
    }

    public bool DeleteExpense(int id)
    {
        Expense? expense = GetExpenseById(id);

        if (expense == null)
            return false;
        
        _expenses.Remove(expense);

        return true;
    }
}