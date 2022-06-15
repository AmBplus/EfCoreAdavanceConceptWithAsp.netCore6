using Ef.Domain.Product;
using Ef.Domain.ProductCategory;
using EF.EFcore.Repositories;

namespace EF.EFcore.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly Context Context;

    public UnitOfWork(Context context)
    {
        Context = context;
    }

    private IProductRepository? _productRepository { get; set; }
    private IProductCategoryRepository? _categoryRepository { get; set; }

    public IProductRepository ProductRepository =>
        _productRepository = _productRepository ?? new ProductRepository(Context);

    public IProductCategoryRepository CategoryRepository =>
        _categoryRepository = _categoryRepository ?? new ProductCategoryRepository(Context);

    public void Save()
    {
        Context.SaveChanges();
    }
}