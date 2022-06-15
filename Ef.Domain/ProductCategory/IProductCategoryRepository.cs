using System.Linq.Expressions;
using _01_Framework_RepositoriesContract;

namespace Ef.Domain.ProductCategory;

public interface IProductCategoryRepository : IRepository<long, Category>
{
    List<T> GetCategoryViewModels<T>() where T : IProductCategoryViewModel, new();
    T GetCategoryViewModel<T>(long id) where T : IProductCategoryViewModel;
    T serachOnCategoryViewModel<T>(Expression<Func<T, bool>> expression) where T : IProductCategoryViewModel;
}