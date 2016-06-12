using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAcess
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsDAO dao = new StudentsDAO();
            Console.WriteLine(dao.GetList().Count());
            Console.ReadKey();
        }
    }
}
