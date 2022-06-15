using System.Linq.Expressions;
using Ef.Domain.Product;

namespace EF.EFcore.Repositories;

public class ProductRepository : IProductRepository
{
    private Context Context;

    public ProductRepository(Context context)
    {
        Context = context;
    }

    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public Product GetBy(long entity)
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

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Insert(Product entity)
    {
        throw new NotImplementedException();
    }

    public bool Exist(Expression<Func<Product, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public List<Product> SearchOnList(Expression<Func<Product, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public List<T> GetProductViewModels<T>() where T : IProductViewModel, new()
    {
        throw new NotImplementedException();
    }

    public T GetProductViewModel<T>(long id) where T : IProductViewModel
    {
        throw new NotImplementedException();
    }

    public T searchOnViewModel<T>(Expression<Func<T, bool>> expression) where T : IProductViewModel
    {
        throw new NotImplementedException();
    }
}