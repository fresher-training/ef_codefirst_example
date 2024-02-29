using BusinessLogic.Interface;
using Entitiy;
using Repository;

namespace BusinessLogic
{
    public class UserService : IUserService
    {
        public async Task<int> InsertUser(string email, string password)
        {
            using (AppRepository repository = new AppRepository())
            {
                User user = new User()
                {
                    Email = email,
                    Password = password
                };
                return await repository.Insert<User>(user);
            }
        }
    }
}
