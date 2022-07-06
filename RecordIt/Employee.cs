using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordIt
{
    public record Employee(int id, string firstName, string lastName, int age);
}
