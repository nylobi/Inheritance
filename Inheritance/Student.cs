using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student : Person
    {
        public Student(string name,int id, int yeargroup) : base(name,id)
        {
            YearGroup = yeargroup;
        }
        public int YearGroup { get; private set; }

        public override decimal EvaluatePerformance()
        {
            return(2);
        }

        public void RegisterForExam()
        {
            
        }
    }
}
