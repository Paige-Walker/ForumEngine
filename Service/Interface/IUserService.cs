namespace Service.Interface
{
    using System;
    
    using Data.Models;

    public interface IUserService
    {
         UserModel GetUserById(Guid id);
    }
}