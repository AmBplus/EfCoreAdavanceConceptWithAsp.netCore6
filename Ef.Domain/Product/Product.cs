using Ef.Domain.BaseModel;
using Ef.Domain.ProductCategory;

namespace Ef.Domain.Product;

public class Product : BaseModel<long>
{
    protected Product()
    {
    }

    public Product(string name, double unitPrice, long categoryId)
    {
        Name = name;
        UnitPrice = unitPrice;
        CategoryId = categoryId;
    }

    public void Edit(string name, double unitPrice, long categoryId)
    {
        Name = name;
        UnitPrice = unitPrice;
        CategoryId = categoryId;
    }

    public void ChangeStatus(bool status)
    {
        IsRemoved = status;
    }

    public string Name { get; set; }
    public double UnitPrice { get; set; }
    public bool IsRemoved { get; set; }
    public long CategoryId { get; set; }
    public Category Category { get; set; }
}