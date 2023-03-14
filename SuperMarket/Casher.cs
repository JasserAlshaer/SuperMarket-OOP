using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    internal sealed class Casher : Person ,IAuthantication //casher is a person 
    {
        
        internal Casher(string name) :base(name)
        {
            
            
        }
        internal Casher()
        {
            

        }
        internal Casher(string test, string phone):base(test, phone)
        {
           
        }
        void GenerateInvoice()
        {

        }

       
        public override void SayHi()
        {
            Console.WriteLine("Iam A Casher");
        }

        public void Login()
        {
            Console.WriteLine("Default Login");
        }

        public void Login(string username, string password)
        {
            Console.WriteLine(" Login {0} , / {1}",username,password);
        }

        public override void Logout3()
        {

        }
        public void Test()
        {
            throw new NotImplementedException();
        }

        


        ~ Casher() { }
    }
}
