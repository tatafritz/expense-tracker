public class ExpenseService
{
    private readonly List<Expense> _expenses = new List<Expense>();
    public void AddExpense(Expense expense)
    {
        if (_expenses.Count == 0)
        {
            expense.Id = 1;
        } else
        {
            expense.Id = _expenses.Max(e => e.Id) + 1;
        }

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

        for (int i = 0; i < _expenses.Count; i++)
        {
            _expenses[i].Id = i + 1;
        }

        return true;
    }
}