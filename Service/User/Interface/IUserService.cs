namespace Service.User.Interface
{
    using AutoMapper;

    public interface IUserService
    {
         User GetUserById(Guid id);


    }
}