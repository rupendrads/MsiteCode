using DepartmentsWebApi.Models;
using System.Collections.Generic;

namespace DepartmentsWebApi.Database
{
    public interface IDepartmentDB
    {
        IList<Department> Departments { get; }
        IList<Person> People { get; }
    }
}