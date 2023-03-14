using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    internal abstract class Person
    {
        private string Name  { set; get; }
        private string Phone { set; get; }

        public Person()
        {

        }

        public Person (string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public Person(string name)
        {
            Name = name;

        }

        //public abstract void TestMethod();

        public virtual void SayHi()
        {
            Console.WriteLine("Iam A Person");
        }

    ~Person() { }
    }
}
