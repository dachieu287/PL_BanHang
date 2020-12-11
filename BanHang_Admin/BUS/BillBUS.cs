using System.Collections.Generic;
using DTO;
using DAO;

namespace BUS
{
    public class BillBUS
    {
        private readonly BillDAO dao = null;

        public BillBUS()
        {
            dao = new BillDAO();
        }

        public bool Add(Bill bill)
        {
            return dao.Add(bill);
        }

        public List<Bill> GetAll()
        {
            return dao.GetAll();
        }
    }
}
