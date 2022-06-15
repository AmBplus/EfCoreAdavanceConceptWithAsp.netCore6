using Ef.Domain.ProductCategory;

namespace Ef.Application.Contract.ProductCategory;

public class ProductCategoryViewModel : IProductCategoryViewModel
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string CreationDate { get; set; }
}