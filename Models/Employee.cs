using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMySQL.Models
{
    public class Employee
    {
        public EmployeeContext context;
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
    }
}
