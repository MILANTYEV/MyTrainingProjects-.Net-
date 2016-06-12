using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsBL bl = new StudentsBL();
            Console.WriteLine(bl.GetList().Count());
            Student stud = new Student { FullName = "Test" };
            bl.Add(stud);
            Console.WriteLine(bl.GetList().Count());
            Console.ReadKey();
        }
    }
}
