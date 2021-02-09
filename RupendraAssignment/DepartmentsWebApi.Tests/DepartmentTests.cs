using DepartmentsWebApi.Models;
using DepartmentsWebApi.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace DepartmentsWebApi.Tests
{
    [TestClass]
    public class DepartmentTests
    {
        IList<Person> people = new List<Person>();
        IList<Department> departments = new List<Department>();

        [TestMethod]
        public void GetPeopleInDepartment_Should_Return_People_In_Department()
        {
            //Arrange
            IDepartmentService departmentService = new DepartmentService();
            string departmentName = "Sales";

            //Act
            IList<string> people = departmentService.GetPeopleInDepartment(departmentName);

            //Assert
            Assert.AreEqual(3, people.Count);
        }

        
        [TestMethod]
        public void GetPeopleInDepartment_Should_Return_Empty_List_For_Invalid_Department()
        {
            //Arrange
            IDepartmentService departmentService = new DepartmentService();
            string departmentName = "Marketing";

            //Act
            IList<string> people = departmentService.GetPeopleInDepartment(departmentName);

            //Assert
            Assert.IsTrue(people.Count == 0);
        }

        [TestMethod]
        public void GetDepartmentsByPerson_Should_Return_Deparments_For_Person()
        {
            //Arrange
            IDepartmentService departmentService = new DepartmentService();
            string surName = "Bradshaw";
            string foreName = "Lisa";

            //Act
            IList<string> departments = departmentService.GetDepartmentsByPerson(surName, foreName);

            //Assert
            Assert.AreEqual(2, departments.Count);
            //Assert.AreEqual("Sales", departments.First());
            Assert.IsTrue(departments.Contains("Sales"));
            Assert.IsTrue(departments.Contains("Purchasing"));
        }

        [TestMethod]
        public void GetDepartmentsByPerson_Should_Return_No_Deparments_For_Invalid_Person()
        {
            //Arrange
            IDepartmentService departmentService = new DepartmentService();
            string surName = "Bradshaw1";
            string foreName = "Lisa2";

            //Act
            IList<string> departments = departmentService.GetDepartmentsByPerson(surName, foreName);

            //Assert
            Assert.AreEqual(0, departments.Count);
            //Assert.AreEqual("Sales", departments.First());
            Assert.IsFalse(departments.Contains("Sales"));
            Assert.IsFalse(departments.Contains("Purchasing"));
        }
    }
}
