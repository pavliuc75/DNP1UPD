using DNPAssigment1.Models;

 namespace DNPAssigment1.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}