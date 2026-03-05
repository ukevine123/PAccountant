using Domain.Entities;
using Application.DTO;
using System.Security.Cryptography.X509Certificates;
using Application.Interfaces;
namespace Application.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategory _category;

        //constructor

        public CategoryService(ICategory category)
        {
            _category = category;
        }
       public List<Category> GetAllCategories()
       {
          List<Category> _categories = _category.GetAllCategories();
          return _categories;
       }

        public void CreateCategory(CategoryCreateDTO categoryDTO)
        {
            _category.CreateCategory(categoryDTO);
        }
    }
}