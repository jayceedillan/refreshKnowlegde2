namespace core.IRepository;
public interface IDataRepository<T> where T : class
{
    IQueryable<T> getAll();
    T get(int id);
    T addOrUpdae(T entity);
    // // T Update(T entity);
    bool delete(int id);
}