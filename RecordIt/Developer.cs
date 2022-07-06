using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordIt
{
    public record Developer : Employee
    {
        public string Technology { get; set; }

        public Developer(int id, string firstName, string lastName, int age, string technology) 
            : base(id, firstName, lastName, age)
        {
            this.Technology = technology;
        }
    }
}
