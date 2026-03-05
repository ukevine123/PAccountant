using Application.DTO;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICategoryService
    {
        public List<Category> GetAllCategories();
        void CreateCategory(CategoryCreateDTO categoryDTO);
    }
}