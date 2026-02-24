
using Application.DTO.Budget;
using Domain.Entities;
using Application.Interfaces;

namespace Application.Services.Budgets
{
    public class BudgetService : IBudgetService
    { 
      private readonly IBudget  _budget;

      // constructor
    public BudgetService (IBudget budgets)
        {
            _budget = budgets;
        }


        public List<Budget> GetAllBudgets()
        {
           List<Budget> budgets = _budget.GetAllBudgets();
            return budgets;
        }
        public Budget GetBudgetById(int id)
        {
            return _budget.GetBudgetById(id);
        }
        public void CreateBudget(BudgetCreateDTO budgetDTO)
        {
            _budget.CreateBudget(budgetDTO);
        }
        public void UpdateBudget(int id, BudgetUpdateDTO budgetDTO)
        {
            _budget.UpdateBudget(id, budgetDTO);
        }
    }
}



