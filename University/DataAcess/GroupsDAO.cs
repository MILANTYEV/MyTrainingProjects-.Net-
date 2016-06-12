using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAcess
{
    public class GroupsDAO : IDAO<Group>
    {
        private UniversityContext _context;

        public GroupsDAO()
        {
            _context = new UniversityContext();
        }

        public IEnumerable<Group> GetList()
        {
            return _context.Groups.ToList<Group>();
        }

        public void Add(Group group)
        {
            if (group == null)
            {
                throw new ArgumentNullException("Null group");
            }
            _context.Groups.Add(group);
            _context.SaveChanges();
        }

        public void Edit(Group group)
        {
            var editGroup = _context.Groups.Where(gr => gr.GroupNumber == group.GroupNumber).FirstOrDefault<Group>();
            editGroup.Course = group.Course;
            editGroup.SpecialtyID = group.SpecialtyID;
            //editGroup.Specialty = group.Specialty;
            _context.Entry(editGroup).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Group parGroup)
        {
            _context.Groups.Remove((from gr in _context.Groups
                                    where gr.GroupNumber == parGroup.GroupNumber
                                    select gr).FirstOrDefault());
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
