using Week2_2280603263.Models;

namespace Week2_2280603263.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
