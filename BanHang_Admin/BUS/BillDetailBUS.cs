using System.Collections.Generic;
using DTO;
using DAO;

namespace BUS
{
    public class BillDetailBUS
    {
        private readonly BillDetailDAO dao = null;

        public BillDetailBUS()
        {
            dao = new BillDetailDAO();
        }

        public BillDetail GetProductDetail(string id)
        {
            return dao.GetProductDetail(id);
        }

        public BillDetail GetComboDetail(string id)
        {
            return dao.GetComboDetail(id);
        }

        public string CheckQuantityCombo(string id, int quantity)
        {
            string result = "";
            List<ComboDetail> comboDetails = (new ComboDetailDAO()).GetByComboID(id);
            foreach (ComboDetail comboDetail in comboDetails)
            {
                int storage = (new ProductDAO()).GetQuantity(comboDetail.Product.ID);
                if ((quantity * comboDetail.Quantity) > storage)
                {
                    result += comboDetail.Product.ID + " ";
                }
            }
            return result;
        }
    }
}
