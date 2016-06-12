using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAcess
{
    public class FacultiesDAO : IDAO<Faculty>
    {
        private UniversityContext _context;

        public FacultiesDAO()
        {
            _context = new UniversityContext();
        }

        public IEnumerable<Faculty> GetList()
        {
            return _context.Faculties.ToList<Faculty>();
        }

        public void Add(Faculty faculty)
        {
            if (faculty == null)
            {
                throw new ArgumentNullException("Null faculty");
            }
            _context.Faculties.Add(faculty);
            _context.SaveChanges();
        }

        public void Edit(Faculty faculty)
        {
            var editFaculty = _context.Faculties.Where(f => f.FacultyID == faculty.FacultyID).FirstOrDefault<Faculty>();
            editFaculty.Title = faculty.Title;
            editFaculty.Dean = faculty.Dean;
            editFaculty.PhoneNumber = faculty.PhoneNumber;
            _context.Entry(editFaculty).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Faculty parFaculty)
        {
            _context.Faculties.Remove((from fac in _context.Faculties
                                          where fac.FacultyID == parFaculty.FacultyID
                                          select fac).FirstOrDefault());
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
