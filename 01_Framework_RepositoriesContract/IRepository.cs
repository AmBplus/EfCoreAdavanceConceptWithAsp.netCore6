using System.Linq.Expressions;

namespace _01_Framework_RepositoriesContract;

public interface IRepository<in TInter, T>
{
    List<T> GetAll();
    T GetBy(TInter entity);
    void Save();
    void Delete(TInter entity);
    void Update(T entity);
    void Insert(T entity);
    bool Exist(Expression<Func<T, bool>> expression);
    List<T> SearchOnList(Expression<Func<T, bool>> expression);
}