using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Extratask7
{
    internal abstract class User
    {
        public abstract List<IndividualUser> UserInfo();
    }

    internal class UserDetails : User
    {


        public override List<IndividualUser> UserInfo()
        {
            IndividualUser individualUserDetails = new IndividualUser();

            Console.Write("Enter customer Name: ");
            individualUserDetails.customerName = Console.ReadLine();
            Console.Write("Enter your contact number: ");
            individualUserDetails.contactNo = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter your Email-id: ");
            individualUserDetails.emailId = Console.ReadLine();
            Console.Write("Enter your Home address: ");
            individualUserDetails.homeAddress = Console.ReadLine();


            List<IndividualUser> perUserDetails = new List<IndividualUser>();
            perUserDetails.Add(individualUserDetails);
            return perUserDetails;
        }
    }


    internal class DisplayAllUsers
    {
        public void ShowAllUsers(List<List<IndividualUser>> userList)
        {

            foreach (List<IndividualUser> particularUser in userList)
            {
                foreach (IndividualUser userObj in particularUser)
                {
                    Console.WriteLine(
                        $"Customer Name: {userObj.customerName}   Customer Contact Number: {userObj.contactNo}   Customer Email-Id: {userObj.emailId}   Home Address: {userObj.homeAddress}"
                    );
                }
            }
        }

    }
}
