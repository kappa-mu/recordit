using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordIt
{
    public record Admin : Employee
    {
        public string Department { get; set; }

        public Admin(int id, string firstName, string lastName, int age, string department) 
            : base(id, firstName, lastName, age)
        {
            this.Department = department;
        }
    }
}
