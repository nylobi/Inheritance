using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Bob", 002, 6);
            {
                s.SendMessage("Hello Bob");
            }

            var t = new Teacher("Jeff", 003);
            {
                t.SendMessage("Your nem es Jeff");
            }
            Console.ReadKey();
        }
    }
}
