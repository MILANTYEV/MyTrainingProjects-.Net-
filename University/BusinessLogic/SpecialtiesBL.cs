using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAcess;

namespace BusinessLogic
{
    public class SpecialtiesBL : IDisposable
    {
        private IDAO<Specialty> _specialtiesDAO;

        public SpecialtiesBL()
        {
            _specialtiesDAO = new SpecialtiesDAO();
        }

        public List<Specialty> GetList()
        {
            return _specialtiesDAO.GetList().ToList<Specialty>();
        }

        public void Dispose()
        {
            _specialtiesDAO.Dispose();
        }
    }
}
