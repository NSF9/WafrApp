using Wafr.Models.Entities;

public interface IWeeklyExpenseRepository
{
    clsWeeklyExpense? GetByID(int weeklyExpenseID);

    List<clsWeeklyExpense> GetByWeekID(int weekID);

    int Create(clsWeeklyExpense weeklyExpense);

    bool Update(clsWeeklyExpense weeklyExpense);

    bool Delete(int weeklyExpenseID);
}