using EgzamenDaw.Models;
using EgzamenDaw.Repositories.GenericRepository;

namespace EgzamenDaw.Repositories.UserRepository
{
    public interface IUserRepository: IGenericRepository<User>
    {
        Task<User> FindByUsername(string username);
        //Task<User> FindByUsernameAndPassword(string username, string password);


        Task<List<User>> FindAll();


    }
}
