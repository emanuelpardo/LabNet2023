using BE;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MP;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Tests
{
    [TestClass()]
    public class MP_SuppliersTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            var MockDBSet = new Mock<DbSet<Suppliers>>();

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(mo => mo.Suppliers).Returns(MockDBSet.Object);

            MP_Suppliers mpSuppliers = new MP_Suppliers(mockContext.Object);
            mpSuppliers.Insert(new Suppliers { 
                CompanyName = "hola",
                ContactTitle = "q", 
                ContactName = "w" , 
                City = "ba" });

            MockDBSet.Verify(mo => mo.Add(It.IsAny<Suppliers>()), Times.Once);
            mockContext.Verify(mo => mo.SaveChanges(), Times.Once);

        }
    }
}