﻿namespace bacit_dotnet.MVC.Repositories
{
    public interface IUserRepository
    {
        void Save(UserEntity user);
        List<UserEntity> GetUsers();
    }
}