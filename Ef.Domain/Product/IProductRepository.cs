using System.Linq.Expressions;
using _01_Framework_RepositoriesContract;

namespace Ef.Domain.Product;

public interface IProductRepository : IRepository<long, Product>
{
    List<T> GetProductViewModels<T>() where T : IProductViewModel, new();
    T GetProductViewModel<T>(long id) where T : IProductViewModel;
    T searchOnViewModel<T>(Expression<Func<T, bool>> expression) where T : IProductViewModel;
}