using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    internal sealed class Customer : Person
    {

        
        public string Visa { get; set; }
        public double CashCredait
        {
            set
            {
                if(value < 0) 
                    CashCredait = 0;
                CashCredait = value;
            }
            get
            {
                double c = CashCredait;
                return c;
            }

        }

        


        public Customer()
        {

        }
        internal Customer(double cashCredait)
        {
            this.CashCredait = cashCredait;
        }
        internal Customer(string name)
        {

        }
        internal Customer(string name,double cashCredait)
        {
           //this.Name = name;
            this.CashCredait = cashCredait;
        }

        internal Customer(string name, string phone,string visa)
        {

        }
        internal Customer(string name, string phone, double cashCredit)
        {

        }
        internal Customer(string name, string phone, string visa,double cashCredit):base(name,phone)
        {
            Visa = visa;
            CashCredait=cashCredit;
            
        }

        internal void AddItemsToCart(int itemId, int Qtn)
        {

        }

        internal void RemoveItemsToCart(int itemId)
        {

        }

        internal void Pay()
        {

        }

       

        //public override void TestMethod()
        //{

        //}

        public override void SayHi()
        {
            Console.WriteLine("Iam A Customer");
        }

        ~ Customer() { }
        


    }
}
