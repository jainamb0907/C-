using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Extratask7
{
    internal class Program
    {


        static void Main(string[] args)
        {

            List<IndividualUser> individualUserDetailsList = new List<IndividualUser>();
            List<List<IndividualUser>> userList = new List<List<IndividualUser>>();

            Orders orders = new Orders();
            ShowAllOrders showAllOrders = new ShowAllOrders();

            UserDetails userDetails = new UserDetails();
            DisplayAllUsers allUsers = new DisplayAllUsers();
            Bill bill = new Bill();

            List<OrderDetails> itemList = new List<OrderDetails>();
            List<List<OrderDetails>> orderList = new List<List<OrderDetails>>();



        Menu:
            Console.WriteLine("-----Options for the User-----");
            Console.WriteLine(
                "Enter your choice from: "
                    + "\n 0 - : Add a new user"
                    + "\n 1 - : Dispplay all users"
                    + "\n 2 - : Display all orders"
                    + "\n 3 - : Display latest orders"
                    + "\n 4 - : Display Bill"
            );


            int choice = Convert.ToInt32(Console.ReadLine());


            if (choice >= 0 && choice < 5)
            {
                Console.WriteLine("You choose: " + choice);
            }


            string ch;
            switch (choice)
            {
                case 0:

                    individualUserDetailsList = userDetails.UserInfo();

                    List<IndividualUser> particularUserDetails()
                    {
                        return individualUserDetailsList;
                    }
                    userList.Add(individualUserDetailsList);

                    List<List<IndividualUser>> AllUsers()
                    {
                        return userList;
                    }


                    itemList = orders.TakeOrders();

                    List<OrderDetails> AllItems()
                    {
                        return itemList;
                    }
                    orderList.Add(itemList);

                    List<List<OrderDetails>> AllOrders()
                    {
                        return orderList;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Do you want to Continue? press Y for Yes and N for No");
                    ch = Console.ReadLine();
                    if (ch == "y" || ch == "Y")
                    {
                        goto Menu;
                    }
                    else
                    {
                        break;
                    }


                case 1:

                    List<IndividualUser> singleUserDetails = new List<IndividualUser>();
                    singleUserDetails = particularUserDetails();
                    List<List<IndividualUser>> allUserList = new List<List<IndividualUser>>();
                    allUserList = AllUsers();

                    allUsers.ShowAllUsers(allUserList);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to Continue? press Y for Yes and N for No");
                    ch = Console.ReadLine();
                    if (ch == "y" || ch == "Y")
                    {
                        goto Menu;
                    }
                    else
                    {
                        break;
                    }

                case 2:
                    List<OrderDetails> individualOrder = new List<OrderDetails>();
                    individualOrder = AllItems();
                    List<List<OrderDetails>> ordersList = new List<List<OrderDetails>>();
                    ordersList = AllOrders();

                    showAllOrders.ShowEveryOrders(ordersList);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to Continue? press Y for Yes and N for No");
                    ch = Console.ReadLine();
                    if (ch == "y" || ch == "Y")
                    {
                        goto Menu;
                    }
                    else
                    {
                        break;
                    }

                case 3:
                    if (orderList.Count > 0)
                    {
                        List<OrderDetails> latestOrder = orderList[orderList.Count - 1];
                        foreach (var el in latestOrder)
                        {
                            Console.WriteLine(
                                $"Name: {el.Name}   Quantity: {el.quantity}   Rate: {el.rate}   Amount: {el.rate * el.quantity}"
                            );
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Do you want to Continue? press Y for Yes and N for No");
                    ch = Console.ReadLine();
                    if (ch == "y" || ch == "Y")
                    {
                        goto Menu;
                    }
                    else
                    {
                        break;
                    }

                case 4:

                    ordersList = AllOrders();
                    allUserList = AllUsers();
                    bill.ShowBill(allUserList, ordersList);

                    Console.WriteLine();
                    Console.WriteLine("Do you want to Continue? press Y for Yes and N for No");
                    ch = Console.ReadLine();
                    if (ch == "y" || ch == "Y")
                    {
                        goto Menu;
                    }
                    else
                    {
                        break;
                    }


                default:
                    Console.WriteLine("Please, enter a valid input");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to Continue? press Y for Yes and N for No");
                    ch = Console.ReadLine();
                    if (ch == "y" || ch == "Y")
                    {
                        goto Menu;
                    }
                    else
                    {
                        break;
                    }

            }
        }
    }
}
