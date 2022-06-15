using _01_Framework_RepositoriesContract;

namespace Ef.Application.Contract.ProductCategory;

public interface IProductCategoryApplication : IRepositoryApplication<ProductCategoryCreateViewModel,
    ProductCategoryUpdateViewModel, ProductCategoryViewModel>
{
}