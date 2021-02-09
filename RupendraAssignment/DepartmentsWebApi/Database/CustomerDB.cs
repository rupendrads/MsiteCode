using DepartmentsWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentsWebApi.Database
{
    public class CustomerDB : ICustomerDB
    {
        IList<Customer> customers = new List<Customer>();

        public CustomerDB()
        {
            SetCustomers();
        }

        public IList<Customer> Customers
        {
            get
            {
                return customers;
            }
        }

        private void SetCustomers()
        {
            this.customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Customer 1",
                    X = 10,
                    Y = 20
                },
                new Customer
                {
                    Id = 2,
                    Name = "Customer 2",
                    X = 90,
                    Y = 24
                },
                new Customer
                {
                    Id = 3,
                    Name = "Customer 3",
                    X = 34,
                    Y = 63
                },
                new Customer
                {
                    Id = 4,
                    Name = "Customer 4",
                    X = 67,
                    Y = 1
                },
                new Customer
                {
                    Id = 5,
                    Name = "Customer 5",
                    X = 24,
                    Y = 84
                },
                new Customer
                {
                    Id = 6,
                    Name = "Customer 6",
                    X = 51,
                    Y = 44
                },
                new Customer
                {
                    Id = 7,
                    Name = "Customer 7",
                    X = 97,
                    Y = 92
                },
                new Customer
                {
                    Id = 8,
                    Name = "Customer 8",
                    X = 77,
                    Y = 13
                },
                new Customer
                {
                    Id = 9,
                    Name = "Customer 9",
                    X = 35,
                    Y = 39
                },
                new Customer
                {
                    Id = 10,
                    Name = "Customer 10",
                    X = 85,
                    Y = 29
                }
            };
        }
    }
}
