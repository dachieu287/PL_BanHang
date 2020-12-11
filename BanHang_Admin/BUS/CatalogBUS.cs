using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class CatalogBUS
    {
        private readonly CatalogDAO dao = null;

        public CatalogBUS()
        {
            dao = new CatalogDAO();
        }

        public List<Catalog> GetAll()
        {
            return dao.GetAll();
        }

        public bool Add(Catalog catalog)
        {
            return dao.Add(catalog);
        }

        public bool Update(string id, Catalog catalog)
        {
            return dao.Update(id, catalog);
        }

        public bool Delete(string id)
        {
            return dao.Delete(id);
        }
    }
}
