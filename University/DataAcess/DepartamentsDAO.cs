using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAcess
{
    public class DepartamentsDAO : IDAO<Departament>
    {
        private UniversityContext _context;

        public DepartamentsDAO()
        {
            _context = new UniversityContext();
        }

        public IEnumerable<Departament> GetList()
        {
            return _context.Departaments.ToList<Departament>();
        }

        public void Add(Departament departament)
        {
            if (departament == null)
            {
                throw new ArgumentNullException("Null departament");
            }
            _context.Departaments.Add(departament);
            _context.SaveChanges();
        }

        public void Edit(Departament departament)
        {
            var editDepartament = _context.Departaments.Where
                (d => d.DepartamentID == departament.DepartamentID).FirstOrDefault<Departament>();
            editDepartament.FacultyID = departament.FacultyID;
            editDepartament.Title = departament.Title;
            editDepartament.DepartamentHead = departament.DepartamentHead;
            editDepartament.PhoneNumber = departament.PhoneNumber;
            _context.Entry(editDepartament).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Departament parDepartament)
        {
            _context.Departaments.Remove((from dep in _context.Departaments
                                          where dep.DepartamentID == parDepartament.DepartamentID
                                          select dep).FirstOrDefault());
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
