using BusinessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public void AddCategory(Category category)
        {
            
        }

        public void DeleteCategory(Category category)
        {
            
        }

        public Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            
        }
    }
}