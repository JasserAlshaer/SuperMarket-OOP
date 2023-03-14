using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    internal interface IAuthantication
    {
        public void Login();
        public void Login (string username, string password);

        public  void Logout()
        {
            Console.WriteLine("Default Logout");
        }
        public virtual void Logout3()
        {
            Console.WriteLine("Default Logout 3");
        }
        public abstract void Test();

    }
}
