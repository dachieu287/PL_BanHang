using System.Collections.Generic;
using DTO;
using DAO;

namespace BUS
{
    public class ProductBUS
    {
        private readonly ProductDAO dao = null;

        public ProductBUS()
        {
            dao = new ProductDAO();
        }

        public List<Product> GetAll()
        {
            return dao.GetAll();
        }

        public bool Add(Product product)
        {
            return dao.Add(product);
        }

        public bool Edit(string id, Product product)
        {
            return dao.Edit(id, product);
        }

        public bool Delete(string id)
        {
            return dao.Delete(id);
        }

        public List<Product> Search(string searchString, string searchCatalog)
        {
            return dao.Search(searchString, searchCatalog);
        }

        public bool ChangeQuantity(string id, int quantity, bool isImport)
        {
            return dao.ChangeQuantity(id, quantity, isImport);
        }
    }
}
