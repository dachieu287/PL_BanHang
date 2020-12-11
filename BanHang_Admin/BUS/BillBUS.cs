using System.Collections.Generic;
using DTO;
using DAO;
using System;

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

        public List<Bill> Search(string searchString, DateTime? fromDate, DateTime? toDate, decimal fromTotal, decimal toTotal)
        {
            return dao.Search(searchString, fromDate, toDate, fromTotal, toTotal);
        }
    }
}
