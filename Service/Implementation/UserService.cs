namespace Service.Implementation
{
    using System;

    using Data.Repository.Interface;
    using Data.Models;
   
    using Service.Interface;

    public class UserService : IUserService
    {
        private IRepository<UserModel> _userRepository;

        public UserService(IRepository<UserModel> userRepository)
        {
            this._userRepository = userRepository;
        }

        public UserModel GetUserById(Guid id)
            => this._userRepository.Get(id);
    }
}