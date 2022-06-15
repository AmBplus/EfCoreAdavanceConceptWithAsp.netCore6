using Ef.Domain.BaseModel;

namespace Ef.Domain.ProductCategory;

public class Category : BaseModel<long>
{
    protected Category()
    {
    }

    public Category(string name)
    {
        Name = name;
    }

    public void Edit(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public List<Product.Product> Products { get; set; }
}