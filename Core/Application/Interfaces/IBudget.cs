using Domain.Entities;
using Application.DTO.Budget;
namespace Application.Interfaces
{
    public interface IBudget
    {
        public List<Budget>  GetAllBudgets();

        public Budget GetBudgetById( int id);
       void CreateBudget( BudgetCreateDTO budgetDTO);
       void UpdateBudget( int id, BudgetUpdateDTO budgetDTO);
    }

}
    