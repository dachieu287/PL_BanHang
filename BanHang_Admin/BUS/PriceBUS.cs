using System.Collections.Generic;
using DTO;
using DAO;

namespace BUS
{
    public class PriceBUS
    {
        private readonly PriceDAO dao = null;

        public PriceBUS()
        {
            dao = new PriceDAO();
        }

        public List<Price> GetByProduct()
        {
            return dao.GetByProduct();
        }

        public List<Price> GetByCombo()
        {
            return dao.GetByCombo();
        }

        public List<Price> GetHistoryByProduct(string productid)
        {
            return dao.GetHistoryByProduct(productid);
        }
        
        public List<Price> GetHistoryByCombo(string comboid)
        {
            return dao.GetHistoryByCombo(comboid);
        }

        public bool Update(Price price)
        {
            return dao.Update(price);
        }

        public List<Price> SearchByProduct(string searchString, string searchCatalog)
        {
            return dao.SearchByProduct(searchString, searchCatalog);
        }

        public List<Price> SearchByCombo(string searchString)
        {
            return dao.SearchByCombo(searchString);
        }
    }
}
