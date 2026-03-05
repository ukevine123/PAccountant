using Infrastructure.Data;
using Domain.Entities;
using Application.Interfaces;
using Application.DTO;

namespace Infrastructure.Repositories
{
    public class CategoryRepository : ICategory
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Category> GetAllCategories()
        {
            List<Category> categories = _context.Categories.ToList();
            return categories;
        }
        public void CreateCategory(CategoryCreateDTO categoryDto)
        {
            Category category = new Category
            {
                Name = categoryDto.Name,
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
        
    }
}