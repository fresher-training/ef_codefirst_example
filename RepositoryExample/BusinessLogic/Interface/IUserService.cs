namespace BusinessLogic.Interface
{
    public interface IUserService
    {
        Task<int> InsertUser(string email, string password);
    }
}
