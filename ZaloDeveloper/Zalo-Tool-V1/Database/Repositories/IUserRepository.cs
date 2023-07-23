using Zalo_Tool_V1.Database.Entities;

namespace Zalo_Tool_V1.Database.Repositories
{
    public interface IUserRepository
    {
        void Add(User account);
        List<User> GetAll();
        void Update(User account);
        User GetById(Guid id);
        void Delete(Guid id);
        void DeleteRange(List<Guid> deleteList);
        void DeleteAll();
    }
}
