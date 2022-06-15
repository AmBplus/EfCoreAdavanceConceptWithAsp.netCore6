namespace Ef.Domain.BaseModel;

public class BaseModel<T>
{
    public T Id { get; set; }
    public DateTime CreationDate { get; set; }

    protected BaseModel()
    {
        CreationDate = DateTime.Now;
    }
}