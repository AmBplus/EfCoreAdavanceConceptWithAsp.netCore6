using Ef.Application.Contract.ProductCategory;
using Ef.Domain.ProductCategory;

namespace Ef.Application.ProductCategory;

public class ProductCategoryApplication : IProductCategoryApplication
{
    private readonly IProductCategoryRepository Context;

    public ProductCategoryApplication(IProductCategoryRepository context)
    {
        Context = context;
    }

    public void Insert(ProductCategoryCreateViewModel entity)
    {
        Category Category = new Category(entity.Name);
        {
        }
        ;
        Context.Insert(Category);
    }

    public void Update(ProductCategoryUpdateViewModel entity)
    {
        Category? findProductCategory = Context.GetBy(entity.Id);
        if (findProductCategory != null)
        {
            findProductCategory.Edit(entity.Name);
            Context.Update(findProductCategory);
        }
    }

    public void Delete(long id)
    {
        Context.Delete(id);
    }

    public bool Exits(long id)
    {
        return Context.Exist(x => x.Id == id);
    }

    public bool Exits(string entityName)
    {
        return Context.Exist(x => x.Name == entityName);
    }

    //public bool Exits(Expression<Func<ProductCategoryViewModel, bool>> expression)
    //{
    //    return Context.Exist();
    //}

    public List<ProductCategoryViewModel> GetAll()
    {
        return Context.GetCategoryViewModels<ProductCategoryViewModel>();
    }

    public ProductCategoryViewModel GetViewModel(long id)
    {
        return Context.GetCategoryViewModel<ProductCategoryViewModel>(id);
    }

    public ProductCategoryViewModel Search(string entityName)
    {
        return Context.serachOnCategoryViewModel<ProductCategoryViewModel>(x => x.Name == entityName);
    }

    //public ProductCategoryViewModel Search(Expression<Func<ProductCategoryViewModel, bool>> expression)
    //{
    //    throw new NotImplementedException();
    //}
}