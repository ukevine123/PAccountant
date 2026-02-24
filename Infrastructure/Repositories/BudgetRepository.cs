
using Domain.Entities;
using Infrastructure.Data;
using Application.DTO.Budget;
using Application.Interfaces;

namespace Infrastructure.Repositories
{
    public class BudgetRepository : IBudget
    {
        private readonly ApplicationDbContext _dbContext;
        public BudgetRepository(ApplicationDbContext context)
           { 
             _dbContext = context;
           }

        // Retrieving budgets
        public List<Budget> GetAllBudgets()
        {
            List<Budget> _budgets =_dbContext.Budgets.ToList();
             
            
            return _budgets;
        }
        public Budget GetBudgetById(int id)
        {
           
          return _dbContext.Budgets.FirstOrDefault(c => c.CategoryId == id);
        }

        public List<Budget> GetAllBudgetsByCustomerId(int categoryId)
        {
            List<Budget> _budgets =_dbContext.Budgets.Where(b => b.CategoryId == categoryId).ToList();
             
            
            return _budgets;
        }
        public Budget GetBudgetByCustomerId(int id)
        {
           
          return _dbContext.Budgets.FirstOrDefault(c => c.CategoryId == id);
        }
        
    
    public void CreateBudget(BudgetCreateDTO budgetDTO)
{
    var budget = new Budget // Ensure Domain.Entities is imported
    {
        Name = budgetDTO.Name,
        Status="Active",
        Category=_dbContext.BudgetCategories.Find(budgetDTO.CategoryId),
        MonthlyLimit = budgetDTO.MonthlyLimit // Match your actual Entity property name
    };

    _dbContext.Budgets.Add(budget);
    _dbContext.SaveChanges();
}

public void UpdateBudget(int id, BudgetUpdateDTO budgetUpdateDTO)
{
    var budget = _dbContext.Budgets.Find(id);
    if (budget != null)
    {
        budget.Name = budgetUpdateDTO.Name;
        budget.MonthlyLimit = budgetUpdateDTO.MonthlyLimit;
        // ... other assignments
        _dbContext.SaveChanges(); 
    }
}
    }
}