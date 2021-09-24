using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using memoral.DataLayer;
using memoral.DataLayer.Repositories;

namespace memoral.DataLayer.Services
{
    class ProductRepository : IProductRepository
    {
        MemoralDBEntities db;
        public ProductRepository(MemoralDBEntities db)
        {
            this.db = db;
        }

       

        public List<Product> GetAllProduct()
        {
            return db.Product.ToList();
        }

        public List<string> GetAllProductName()
        {
            return (from product in db.Product.ToList()
            select product.Name).ToList();
        }

        public Product GetProductById(int id)
        {
            return db.Product.Find(id);
        }

        public List<Product> GetProductLike(string likes)
        {
            return db.Product.Where(p => p.Name.Contains(likes)).ToList();
        }

        public bool InsertProduct(Product product)
        {
            try
            {
                db.Product.Add(product);
                return true;
            }
            catch
            {

                return false;
            }

        }
        public bool DeleteProduct(Product product)
        {
            try
            {
                db.Entry(product).State = EntityState.Deleted;
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        

        public bool UpdateProduct(Product product)
        {
            try
            {
                var local = db.Set<Product>()
                    .Local
                    .FirstOrDefault(f => f.ID == product.ID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(product).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void save()
        {
            db.SaveChanges();
        }
    }
}
