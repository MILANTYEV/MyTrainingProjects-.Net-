using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAcess
{
    public class SpecialtiesDAO : IDAO<Specialty>
    {
        private UniversityContext _context;

        public SpecialtiesDAO()
        {
            _context = new UniversityContext();
        }

        public IEnumerable<Specialty> GetList()
        {
            return _context.Specialties.ToList<Specialty>();
        }

        public void Add(Specialty specialty)
        {

        }

        public void Edit(Specialty specialty)
        {

        }

        public void Delete(Specialty specialty)
        {

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
