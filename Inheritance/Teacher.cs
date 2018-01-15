using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Teacher : Person
    {
        public Teacher(string name, int id) : base(name,id)
        {
            
        }

        public override decimal EvaluatePerformance()
        {
            return(4);
        }
    }
}
