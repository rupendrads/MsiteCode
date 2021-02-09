using DepartmentsWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentsWebApi.Database
{
    public class DepartmentDB : IDepartmentDB
    {
        IList<Person> people = new List<Person>();
        IList<Department> departments = new List<Department>();

        public DepartmentDB()
        {
            SetPeople();
            SetDepartments();
        }

        public IList<Person> People
        {
            get
            {
                return people;
            }
        }

        public IList<Department> Departments
        {
            get
            {
                return departments;
            }
        }

        private void SetPeople()
        {
            people = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Surname = "Smith",
                    ForeName = "John",
                    Title = "Mr",
                },
                new Person
                {
                    Id = 2,
                    Surname = "Jones",
                    ForeName = "Steve",
                    Title = "Mr"
                },
                new Person
                {
                    Id = 3,
                    Surname = "Bradshaw",
                    ForeName = "Lisa",
                    Title = "Mrs"
                },
                new Person
                {
                    Id = 4,
                    Surname = "Thompson",
                    ForeName = "Joanne",
                    Title = "Miss"
                },
                new Person
                {
                    Id = 5,
                    Surname = "Johnson",
                    ForeName = "David",
                    Title = "Mr"
                }
            };
        }

        private void SetDepartments()
        {
            departments = new List<Department>
            {
                new Department
                {
                     Id =  1,
                     Name = "Purchasing",
                     Location = "Top Floor",
                     Members = new List<Person>
                    {
                        people.SingleOrDefault(p => p.Id == 1),
                        people.SingleOrDefault(p => p.Id == 2),
                        people.SingleOrDefault(p => p.Id == 3)
                    }
},
                new Department
                {
                    Id = 2,
                    Name = "Sales",
                    Location = "Bottom Floor",
                    Members = new List<Person>
                    {
                        people.SingleOrDefault(p => p.Id == 3),
                        people.SingleOrDefault(p => p.Id == 4),
                        people.SingleOrDefault(p => p.Id == 5)
                    }
                }
            };
        }

    }
}
