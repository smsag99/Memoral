using memoral.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoral.DataLayer.Repositories
{
    public interface IProductRepository
    {
       
        List<Product> GetAllProduct();
        List<Product> GetProductLike(string likes);
        Product GetProductById(int id);
        bool InsertProduct(Product product);
        bool DeleteProduct(Product product);
        bool UpdateProduct(Product product);
        List<string> GetAllProductName();
        void save();

    }
}
