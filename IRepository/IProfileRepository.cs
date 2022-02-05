using core.Models;
namespace core.IRepository;
public interface IProfileRepository : IDataRepository<ProfileViewModel>
{
    // IEnumerable<T> GetAll();
    IQueryable<ProfileViewModel> getAll();
    ProfileViewModel get(int id);

    ProfileViewModel addOrUpdae(ProfileViewModel entity);
    // T Add(T entity);
    // // T Update(T entity);
    bool delete(int id);
}