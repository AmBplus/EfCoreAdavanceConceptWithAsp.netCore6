using Ef.Domain.Product;
using Ef.Domain.ProductCategory;

namespace EF.EFcore.UnitOfWork;

public interface IUnitOfWork
{
    IProductRepository ProductRepository { get; }
    IProductCategoryRepository CategoryRepository { get; }
    void Save();
}