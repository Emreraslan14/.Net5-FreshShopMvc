using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshShop.DataAccess.Abstract
{
    public interface IManagerRepository : IRepository<Manager>
    {
        Manager LogIn(string UserName, string Password);
        Manager GetByEmail (string email);
    }
}
