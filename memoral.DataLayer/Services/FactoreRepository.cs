using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using memoral.DataLayer.Repositories;

namespace memoral.DataLayer.Services
{
     class FactoreRepository : IFactoreRepository
    {
        MemoralDBEntities db;

        public FactoreRepository(MemoralDBEntities db)
        {
            this.db = db;
        }
        public List<Factore> GetAllFactores()
        {
            return db.Factore.ToList();
        }

        public List<Factore> GetFactoresByFactoreId(int Id=0)
        {
            if (Id == 0)
                return GetAllFactores();
            return db.Factore.Where(f => f.FactoreId == Id).ToList();
        }

        public int GetMaxFactoreId()
        {
            try
            {
                return db.Factore.Max(f => f.FactoreId);
            }
            catch { return 0; }
        }

        public bool InsertFactore(Factore factore)
        {
            try
            {
                db.Factore.Add(factore);
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
