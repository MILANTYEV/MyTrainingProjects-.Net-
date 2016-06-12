using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAcess;

namespace DataAcessTest
{
    [TestClass]
    public class UniversityContextTest
    {
        [TestMethod]
        public void TestGetFirstStudent()
        {
            UniversityContext context = new UniversityContext();

            var count = context.Students.Count();

            Assert.AreEqual(count, 31);
        }
    }
}
