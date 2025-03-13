using Week2_2280603263.Models;

namespace Week2_2280603263.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private List<Category> _categoryList;

        public MockCategoryRepository() 
        {
            _categoryList = new List<Category>
            {
                new Category { Id = 1, Name = "Acer" },
                new Category { Id = 2, Name = "Asus" },
                new Category { Id = 3, Name = "Dell"},
                new Category { Id = 4, Name = "HP"},
                new Category { Id = 5, Name = "Lenovo"},
                new Category { Id = 6, Name = "MacBook"},
            };
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryList;
        }
    }
}
