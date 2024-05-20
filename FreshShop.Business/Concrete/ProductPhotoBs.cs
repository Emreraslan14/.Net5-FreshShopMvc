using FreshShop.Business.Abstract;
using FreshShop.DataAccess.Abstract;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreshShop.Business.Concrete
{
    public class ProductPhotoBs : IProductPhotoBs
    {
        private readonly IProductPhotoRepository _repo;
        public ProductPhotoBs(IProductPhotoRepository repo)
        {
            _repo = repo;
        }
        public void Delete(ProductPhoto entity)
        {
            //Loglama
            //Cachleme
            //Validation...             
            _repo.Delete(entity);
        }

        public ProductPhoto Get(Expression<Func<ProductPhoto, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<ProductPhoto> GetAll(Expression<Func<ProductPhoto, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }
        
        public ProductPhoto GetById(int id)
        {
            return _repo.GetById(id);
        }

        public int Insert(ProductPhoto entity)
        {
            //Loglama
            //Cachleme
            //Validation... 
            return _repo.Insert(entity);
        }

        public void Update(ProductPhoto entity)
        {
            _repo.Update(entity);
        }
    }

}
