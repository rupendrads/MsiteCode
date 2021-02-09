using DepartmentsWebApi.Models;
using System.Collections.Generic;

namespace DepartmentsWebApi.Database
{
    public interface ICustomerDB
    {
        IList<Customer> Customers { get; }
    }
}