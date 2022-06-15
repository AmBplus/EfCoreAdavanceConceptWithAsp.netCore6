using _01_Framework_RepositoriesContract;

namespace Ef.Application.Contract.Product;

public interface IProductApplication : IRepositoryApplication<ProductCreateViewModel, ProductUpdateViewModel,
    ProductCategoryViewModel>
{
}