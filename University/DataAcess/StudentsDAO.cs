using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAcess
{
    public class StudentsDAO : IDAO<Student>
    {
        private UniversityContext _context;

        public StudentsDAO()
        {
            _context = new UniversityContext();
        }

        public IEnumerable<Student> GetList()
        {
            return _context.Students.ToList<Student>();
        }

        public void Add(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Null student");
            }
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Edit(Student student)
        {
            var editStud = _context.Students.Where(st=>st.StudentID == student.StudentID).FirstOrDefault<Student>();
            editStud.BirthDate = student.BirthDate;
            editStud.FullName = student.FullName;
            editStud.GroupNumber = student.GroupNumber;
            editStud.StudentRecordNumber = student.StudentRecordNumber;
            _context.Entry(editStud).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Student student)
        {
            int id = student.StudentID;
            Student delStud = (from stud in _context.Students 
                                     where stud.StudentID == id
                                     select stud).First();
            _context.Students.Remove(delStud);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
