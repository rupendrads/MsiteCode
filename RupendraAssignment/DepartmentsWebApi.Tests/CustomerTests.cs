using DepartmentsWebApi.Services;
using DepartmentsWebApi.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DepartmentsWebApi.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void FindCustomersShortetRoute_Should_Return_Shortest_Path_0_0()
        {
            //Arrange
            ICustomerService customerService = new CustomerService();
            int x = 0;
            int y = 0;

            //Act
            customerService.FindCustomersShortetRoute(x, y);

            //Assert
            Assert.IsTrue(customerService.TotalDistanceTravelled > 0);
            Assert.AreEqual(10, customerService.FilteredCustomers.Count);
            System.Diagnostics.Debug.WriteLine("Total distance travelled: " + customerService.TotalDistanceTravelled);
            System.Diagnostics.Debug.WriteLine("Customers Visited");
            foreach(string customer in customerService.FilteredCustomers)
            {
                System.Diagnostics.Debug.WriteLine(customer);
            }
        }
        [TestMethod]
        public void FindCustomersShortetRoute_Should_Return_Shortest_Path_100_100()
        {
            //Arrange
            ICustomerService customerService = new CustomerService();
            int x = 100;
            int y = 100;

            //Act
            customerService.FindCustomersShortetRoute(x, y);

            //Assert
            Assert.IsTrue(customerService.TotalDistanceTravelled > 0);
            Assert.AreEqual(10, customerService.FilteredCustomers.Count);
            System.Diagnostics.Debug.WriteLine("Total distance travelled: " + customerService.TotalDistanceTravelled);
            System.Diagnostics.Debug.WriteLine("Customers Visited");
            foreach (string customer in customerService.FilteredCustomers)
            {
                System.Diagnostics.Debug.WriteLine(customer);
            }
        }

        [TestMethod]
        public void FindCustomersShortetRoute_Should_Return_Shortest_Path_50_50()
        {
            //Arrange
            ICustomerService customerService = new CustomerService();
            int x = 50;
            int y = 50;

            //Act
            customerService.FindCustomersShortetRoute(x, y);

            //Assert
            Assert.IsTrue(customerService.TotalDistanceTravelled > 0);
            Assert.AreEqual(10, customerService.FilteredCustomers.Count);
            System.Diagnostics.Debug.WriteLine("Total distance travelled: " + customerService.TotalDistanceTravelled);
            System.Diagnostics.Debug.WriteLine("Customers Visited");
            foreach (string customer in customerService.FilteredCustomers)
            {
                System.Diagnostics.Debug.WriteLine(customer);
            }
        }
    }
}
