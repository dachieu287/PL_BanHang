using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ComboDetailBUS
    {
        private readonly ComboDetailDAO dao = null;

        public ComboDetailBUS()
        {
            dao = new ComboDetailDAO();
        }
        public List<ComboDetail> GetByComboID(string comboid)
        {
            return dao.GetByComboID(comboid);
        }

        public bool Add(ComboDetail comboDetail)
        {
            return dao.Add(comboDetail);
        }

        public bool Delete(string comboid, string productid)
        {
            return dao.Delete(comboid, productid);
        } 
    }
}
