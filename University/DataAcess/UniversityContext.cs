using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAcess
{
    class UniversityContext : DbContext
    {
        public UniversityContext() : base("University") { }

        public DbSet<Student> Students { get; set; }

        public DbSet<Faculty> Faculties { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Departament> Departaments { get; set; }

        public DbSet<Specialty> Specialties { get; set; }
    }
}
