using System.Linq.Expressions;
using Ef.Application.Contract.Product;

namespace Ef.Application.Product;

public class ProductApplication : IProductApplication
{
    public void Insert(ProductCreateViewModel entity)
    {
        throw new NotImplementedException();
    }

    public void Update(ProductUpdateViewModel entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(long id)
    {
        throw new NotImplementedException();
    }

    public bool Exits(long id)
    {
        throw new NotImplementedException();
    }

    public bool Exits(string entityName)
    {
        throw new NotImplementedException();
    }

    public bool Exits(Expression<Func<ProductCategoryViewModel, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public List<ProductCategoryViewModel> GetAll()
    {
        throw new NotImplementedException();
    }

    public ProductCategoryViewModel GetViewModel(long id)
    {
        throw new NotImplementedException();
    }

    public ProductCategoryViewModel Search(string entityName)
    {
        throw new NotImplementedException();
    }

    public ProductCategoryViewModel Search(Expression<Func<ProductCategoryViewModel, bool>> expression)
    {
        throw new NotImplementedException();
    }
}