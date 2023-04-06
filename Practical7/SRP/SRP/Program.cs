using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single Responsibility Principle:
            //A class should have only one reason to change
            //Every class or module should have single responsibility, and that responsibility should be entirely encapsulated by class
            //Each class and module should focus on single task only
            //Everything in class should be related to that single purpose

            // Without SRP
            UserWithoutSRP user = new UserWithoutSRP();
            user.Register("jainam", "jainam@123", "jainam Bhavsar");
            user.Login("jainam", "jainam@123");

            //Now there is a problem: In future if we want to change Logging mechanism or Email related functions than user class needs to be changed which is violating SRP principle

            // With SRP
            UserWithSRP userWithSRP = new UserWithSRP();
            Console.WriteLine();
            userWithSRP.Register("jainam", "jainam@123", "jainam Bhavsar");
            userWithSRP.Login("jainam", "jainam@123");
        }
    }
}
