using FreshShop.Business.Abstract;
using FreshShop.DataAccess.Abstract;
using FreshShop.DataAccess.Concrete;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreshShop.Business.Concrete
{

    //Tightly Coupled(Sıkı Sıkıya Bağlı)
    //Loosely Coupled(Gevşek Bağlılık)

    //Dependency Injection(Bağımlılığın  dışarıdan enjekte edilmesi)

    public class ManagerBs : IManagerBs
    { 
        private readonly IManagerRepository _repo;
        public ManagerBs(IManagerRepository repo) //Constructor Injection
        {
            _repo = repo;
        }
        public void Delete(Manager entity)
        {
            _repo.Delete(entity);
        }

        public Manager Get(Expression<Func<Manager, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<Manager> GetAll(Expression<Func<Manager, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }

        public Manager GetByEmail(string email)
        {
            return _repo.GetByEmail(email);
        }

        public Manager GetById(int id)
        {
            return _repo.GetById(id);
        }

        public int Insert(Manager entity)
        {
            return _repo.Insert(entity);
        }

        public Manager LogIn(string UserName, string Password)
        {
            return _repo.LogIn(UserName, Password);
        }

        public void Update(Manager entity)
        {
            _repo.Update(entity);
        }
    }
}
