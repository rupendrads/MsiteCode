using DepartmentsWebApi.Database;
using DepartmentsWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentsWebApi.Services
{
    public class DepartmentService : IDepartmentService
    {
        IDepartmentDB database = new DepartmentDB();
        public IList<string> GetPeopleInDepartment(string departmentName)
        {
            var department = database.Departments.SingleOrDefault(d => d.Name == departmentName);

            IList<string> people = new List<string>();

            if (department != null)
            {
                foreach(var person in department.Members)
                {
                    people.Add(person.Surname);
                }
            }

            return people;
        }

        public IList<string> GetDepartmentsByPerson(string surName, string foreName)
        {
            IList<string> departments = new List<string>();

            var people = database.People.Where(p => p.ForeName == foreName && p.Surname == surName);

            foreach(var person in people)
            {
               var depts = database.Departments.Where(dept => dept.Members.Contains(person)).Select(d => d.Name);
                foreach(var dept in depts)
                {
                    if(!departments.Contains(dept))
                    {
                        departments.Add(dept);
                    }
                }
            }
             
            return departments;
        }
    }
}
