using Domain.Entities;
using Application.DTO.Budget;

namespace Application.Services.Budgets
{
    public interface IBudgetService
    {
        Budget GetBudgetById(int id);
        List<Budget> GetAllBudgets();
        
        void CreateBudget(BudgetCreateDTO budgetDTO);
        void UpdateBudget(int id, BudgetUpdateDTO budgetDTO);
        
    }
}