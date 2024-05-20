using FreshShop.DataAccess.Abstract;
using FreshShop.DataAccess.Context;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshShop.DataAccess.Concrete
{
    public class ManagerRepository : RepositoryBase<Manager, FreshShopDbContext>, IManagerRepository
    {
        public Manager GetByEmail(string email)
        {
            return Get(x => x.Email == email);
        }

        public Manager LogIn(string UserName, string Password)
        {
            return Get(x => x.UserName == UserName && x.Password == Password);
        }
    }
}
