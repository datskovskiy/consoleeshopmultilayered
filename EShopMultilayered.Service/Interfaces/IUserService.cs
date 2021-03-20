using EShopMultilayered.DataAccess.Entities;
using EShopMultilayered.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EShopMultilayered.Service.Interfaces
{
    public interface IUserService
    {
        User Register(User user, string password);
        User Login(string username, string password);
        bool UserExists(string username);
        void UpdateUser(IUser user, string newEmail);
        IReadOnlyList<User> GetUsers();
    }
}
