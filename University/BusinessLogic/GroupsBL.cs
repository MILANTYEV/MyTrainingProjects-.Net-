using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess;
using Entities;

namespace BusinessLogic
{
    public class GroupsBL : IDisposable
    {
        private IDAO<Group> _groupsDAO;

        public GroupsBL()
        {
            _groupsDAO = new GroupsDAO();
        }

        public List<Group> GetList()
        {
            return _groupsDAO.GetList().ToList<Group>();
        }

        public void Add(Group group)
        {
            _groupsDAO.Add(group);
        }

        public void Edit(Group group)
        {
            _groupsDAO.Edit(group);
        }

        public void Delete(Group group)
        {
            _groupsDAO.Delete(group);
        }

        public int GetStudentsNumber(Group group)
        {
            int number;
            using (StudentsBL studentsBl = new StudentsBL())
            {
                number = studentsBl.GetList().Count(stud => stud.GroupNumber == group.GroupNumber);
            }
            return number;
        }

        public void Dispose()
        {
            _groupsDAO.Dispose();
        }
    }
}
