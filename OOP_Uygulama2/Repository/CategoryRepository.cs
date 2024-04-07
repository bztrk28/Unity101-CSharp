using OOP_Uygulama2.Models;

namespace OOP_Uygulama2.Repository;

public class CategoryRepository : ICategoryRepository
{
    List<Category> _categories;

    public CategoryRepository()
    {
        _categories = new List<Category>()
        {
            new Category(1,"Türk Klasikleri"),
            new Category(1,"Dünya Klasikleri"),
            new Category(1,"Bilim Kurgu")
        };
    }
    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(int id)
    {
        Category? category = _categories.SingleOrDefault(x => x.Id == id);
        if(category == null)
        {
            // exception fırlat
        }
        _categories.Remove(category);
    }

    public List<Category> GetAll()
    {
        throw new NotImplementedException();
    }

    public Category GetById(int id)
    {
        throw new NotImplementedException();
    }
}
