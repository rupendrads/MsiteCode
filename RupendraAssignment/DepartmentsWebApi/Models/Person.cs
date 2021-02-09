using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentsWebApi.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string ForeName { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }
    }
}
