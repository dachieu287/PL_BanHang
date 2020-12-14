using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ComboBUS
    {
        private readonly ComboDAO dao = null;
        
        public ComboBUS()
        {
            dao = new ComboDAO();
        }
        public List<Combo> GetAll()
        {
            return dao.GetAll();
        }

        public bool Add(Combo combo)
        {
            return dao.Add(combo);
        }

        public bool Edit(string id, Combo combo)
        {
            return dao.Edit(id, combo);
        }

        public bool Delete(string id)
        {
            return dao.Delete(id);
        }

        public List<Combo> Search(string searchString)
        {
            return dao.Search(searchString);
        }

        public string GetName(string id)
        {
            return dao.GetName(id);
        }
    }
}
