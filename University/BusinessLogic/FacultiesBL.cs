using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAcess;

namespace BusinessLogic
{
    public class FacultiesBL : IDisposable
    {
        private IDAO<Faculty> _facultiesDAO;

        public FacultiesBL()
        {
            _facultiesDAO = new FacultiesDAO();
        }

        public List<Faculty> GetList()
        {
            return _facultiesDAO.GetList().ToList<Faculty>();
        }

        public void Add(Faculty faculty)
        {
            _facultiesDAO.Add(faculty);
        }

        public void Edit(Faculty faculty)
        {
            _facultiesDAO.Edit(faculty);
        }

        public void Delete(Faculty faculty)
        {
            _facultiesDAO.Delete(faculty);
        }

        public void Dispose()
        {
            _facultiesDAO.Dispose();
        }
    }
}
