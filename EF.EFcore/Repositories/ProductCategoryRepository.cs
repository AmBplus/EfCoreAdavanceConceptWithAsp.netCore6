using System.Linq.Expressions;
using Ef.Domain.ProductCategory;

namespace EF.EFcore.Repositories;

public class ProductCategoryRepository : IProductCategoryRepository
{
    private Context Context;

    public ProductCategoryRepository(Context context)
    {
        Context = context;
    }

    public List<Category> GetAll()
    {
        throw new NotImplementedException();
    }

    public Category GetBy(long entity)
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public void Delete(long entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Category entity)
    {
        throw new NotImplementedException();
    }

    public void Insert(Category entity)
    {
        throw new NotImplementedException();
    }

    public bool Exist(Expression<Func<Category, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public List<Category> SearchOnList(Expression<Func<Category, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public List<T> GetCategoryViewModels<T>() where T : IProductCategoryViewModel, new()
    {
        throw new NotImplementedException();
    }

    public T GetCategoryViewModel<T>(long id) where T : IProductCategoryViewModel
    {
        throw new NotImplementedException();
    }

    public T serachOnCategoryViewModel<T>(Expression<Func<T, bool>> expression) where T : IProductCategoryViewModel
    {
        throw new NotImplementedException();
    }
}