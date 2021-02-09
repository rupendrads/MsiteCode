using System.Collections.Generic;

namespace DepartmentsWebApi.Services
{
    public interface IDepartmentService
    {
        IList<string> GetPeopleInDepartment(string departmentName);
        IList<string> GetDepartmentsByPerson(string surName, string foreName);
    }
}