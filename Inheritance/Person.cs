using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Person
    {
        public Person(string name, int id)
        {
            Name = name;
            ID = id;
        }
        public string Name { get; private set; }
        public int ID { get; private set; }
        public void SendMessage(string Message)
        {
            Console.WriteLine(Message + " sent to " + Name);
        }
        public abstract decimal EvaluatePerformance();
    }
}
