using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAcess;

namespace BusinessLogic
{
    public class DepartamentsBL : IDisposable
    {
        private IDAO<Departament> _departamentsDAO;

        public DepartamentsBL()
        {
            _departamentsDAO = new DepartamentsDAO();
        }

        public List<Departament> GetList()
        {
            return _departamentsDAO.GetList().ToList<Departament>();
        }

        public void Add(Departament departament)
        {
            _departamentsDAO.Add(departament);
        }

        public void Edit(Departament departament)
        {
            _departamentsDAO.Edit(departament);
        }

        public void Delete(Departament departament)
        {
            _departamentsDAO.Delete(departament);
        }

        public void Dispose()
        {
            _departamentsDAO.Dispose();
        }
    }
}
