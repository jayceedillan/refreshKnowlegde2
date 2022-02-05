using core.Models;
using core.IRepository;

namespace core.Repositry;

public class ProfileRepository : IProfileRepository
{
    readonly ApplicationDBContext dbContext;
    public ProfileRepository(ApplicationDBContext context)
    {
        dbContext = context;
    }

    public ProfileViewModel addOrUpdae(ProfileViewModel entity)
    {
        var profile = new Profile();
        profile.Name = entity.Name;
        profile!.ContactNo = entity.ContactNo;

        if (entity.id != 0)
        {
            profile = dbContext.Profiles.Where(a => a.id == entity.id).SingleOrDefault();
            profile!.Name = entity.Name;
            profile!.ContactNo = entity.ContactNo;
        }
        else
        {
            dbContext.Profiles.Add(profile);
        }
        dbContext.SaveChanges();

        return entity;
    }

    public bool delete(int id)
    {
        var profile = dbContext.Profiles.Where(a => a.id == id).SingleOrDefault();
        dbContext.Profiles.Remove(profile);
        dbContext.SaveChanges();

        return true;
    }

    public ProfileViewModel get(int id)
    {
        var profile = dbContext.Profiles.Where(a => a.id == id).Select(x =>
            new ProfileViewModel
            {
                id = x.id,
                Name = x.Name,
                ContactNo = x.ContactNo
            }).FirstOrDefault();

        return profile;
    }


    // public ProfileViewModel Get(int id) => dbContext.Profiles.Where(x => x.id == id).Select(a =>
    // {
    //     new ProfileViewModel
    //     {

    //     }
    // }).FirstOrDefault();

    public IQueryable<ProfileViewModel> getAll()
    {
        var profiles = dbContext.Profiles.AsQueryable().Select(x =>
             new ProfileViewModel
             {
                 id = x.id,
                 Name = x.Name,
                 ContactNo = x.ContactNo,
             });

        return profiles;
    }


}