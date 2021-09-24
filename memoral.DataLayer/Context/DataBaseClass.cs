using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using memoral.DataLayer;
using memoral.DataLayer.Repositories;
using memoral.DataLayer.Services;

namespace memoral.DataLayer.context
{
    public class DataBaseClass : IDisposable
    {
        private MemoralDBEntities _db = new MemoralDBEntities();
        private IUserRepository _userRepository;
        private IProductRepository _productRepository;
        private IFactoreRepository _factoreRepository;
        
        public IUserRepository userRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_db);
                }
                return _userRepository;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _productRepository = new ProductRepository(_db);
                }

                return _productRepository;
            }
        }

        public IFactoreRepository factoreRepository
        {
            get
            {
                if (_factoreRepository == null)
                {
                    _factoreRepository = new FactoreRepository(_db);
                }
                return _factoreRepository;
            }
        }
        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
