using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoral.DataLayer.Repositories
{
    public interface IFactoreRepository
    {
        List<Factore> GetAllFactores();
        List<Factore> GetFactoresByFactoreId(int Id);
        bool InsertFactore(Factore factore);
        int GetMaxFactoreId();
        void save();
    }
}
