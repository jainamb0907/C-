using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Extratask7
{
    enum Options
    {
        Paneer_butter_Masala = 320,
        Roti = 20,
        Soup = 60,
        Pulav = 94,
        Gulabjamun = 40,
        Allitems = 534
    }

    interface ITakeOrder
    {
        List<OrderDetails> TakeOrders();
    }

    public class Orders : ITakeOrder
    {
        public List<string> itemList = new List<string>();

        int quantity = 0,
            itemChoice,
            i = 0;
        double grandTotal = 0,
            individualPrice = 0;
        string ch;

        public List<OrderDetails> TakeOrders()
        {
            List<OrderDetails> orderDetailsList = new List<OrderDetails>();

            Console.WriteLine("-----Menu for the Customer-----");
            Console.WriteLine(
                "AVilable Options are: "
                    + "\n 1 - : Paneer butter Masala 320"
                    + "\n 2 - : Roti 20"
                    + "\n 3 - : Soup 60"
                    + "\n 4 - : Pulav 94"
                    + "\n 5 - : Gulabjamun 40"
                    + "\n 6 - : Order above all"
            );

            do
            {
                Console.WriteLine("---INSERT YOUR ORDER DETAILS---");
                Console.Write("Enter your item number: ");
                itemChoice = Convert.ToInt32(Console.ReadLine());

                if (0 < itemChoice && itemChoice < 7)
                {
                    Console.Write("Enter product quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                }

                OrderDetails orderDetails = new OrderDetails();
                switch (itemChoice)
                {
                    case 1:

                        orderDetails.Name = Convert.ToString(Options.Paneer_butter_Masala);
                        orderDetails.rate = (int)Options.Paneer_butter_Masala;
                        orderDetails.quantity = quantity;
                        orderDetailsList.Add(orderDetails);

                        itemList.Add(Convert.ToString(Options.Paneer_butter_Masala));
                        individualPrice = quantity * (int)Options.Paneer_butter_Masala;
                        Console.WriteLine("Amount of item is {0}", individualPrice);
                        break;

                    case 2:

                        orderDetails.Name = Convert.ToString(Options.Roti);
                        orderDetails.rate = (int)Options.Roti;
                        orderDetails.quantity = quantity;
                        orderDetailsList.Add(orderDetails);

                        itemList.Add(Convert.ToString(Options.Roti));
                        individualPrice = quantity * (int)Options.Roti;
                        Console.WriteLine("Amount of item is {0}", individualPrice);
                        break;

                    case 3:

                        orderDetails.Name = Convert.ToString(Options.Soup);
                        orderDetails.rate = (int)Options.Soup;
                        orderDetails.quantity = quantity;
                        orderDetailsList.Add(orderDetails);

                        itemList.Add(Convert.ToString(Options.Soup));
                        individualPrice = quantity * (int)Options.Soup;
                        Console.WriteLine("Amount of item is {0}", individualPrice);
                        break;

                    case 4:

                        orderDetails.Name = Convert.ToString(Options.Pulav);
                        orderDetails.rate = (int)Options.Pulav;
                        orderDetails.quantity = quantity;
                        orderDetailsList.Add(orderDetails);

                        itemList.Add(Convert.ToString(Options.Pulav));
                        individualPrice = quantity * (int)Options.Pulav;
                        Console.WriteLine("Amount of item is {0}", individualPrice);
                        break;

                    case 5:

                        orderDetails.Name = Convert.ToString(Options.Gulabjamun);
                        orderDetails.rate = (int)Options.Gulabjamun;
                        orderDetails.quantity = quantity;
                        orderDetailsList.Add(orderDetails);

                        itemList.Add(Convert.ToString(Options.Gulabjamun));
                        individualPrice = quantity * (int)Options.Gulabjamun;
                        Console.WriteLine("Amount of item is {0}", individualPrice);
                        break;

                    case 6:

                        orderDetails.Name = Convert.ToString(Options.Allitems);
                        orderDetails.rate = (int)Options.Allitems;
                        orderDetails.quantity = quantity;
                        orderDetailsList.Add(orderDetails);

                        itemList.Add(Convert.ToString(Options.Allitems));
                        individualPrice = quantity * (int)Options.Allitems;
                        Console.WriteLine("Amount of item is {0}", individualPrice);
                        break;

                    default:
                        Console.WriteLine("Please, enter a valid input");
                        goto wrongSelection;
                }

                grandTotal = grandTotal + individualPrice;

            wrongSelection:
                Console.WriteLine("Your current Total Bill amount is {0}", grandTotal);
                Console.WriteLine("Do you want to add more items? press Y for Yes and N for No");
                ch = Console.ReadLine();
            } while (ch == "y" || ch == "Y");
            grandTotal = 0;
            return orderDetailsList;
        }
    }

    internal class Bill
    {
        public void ShowBill(List<List<IndividualUser>> allUserList, List<List<OrderDetails>> ordersList)
        {
            double grandTotal = 0;


            int i = 0;
            foreach (List<IndividualUser> particularUser in allUserList)
            {


                foreach (IndividualUser userObj in particularUser)
                {
                    Console.WriteLine(
                        $"Customer Name: {userObj.customerName}   Customer Contact Number: {userObj.contactNo}   Customer Email-Id: {userObj.emailId}   Home Address: {userObj.homeAddress}"
                    );
                }

                if (ordersList.Count > 0)
                {
                    List<OrderDetails> particularOrder = ordersList[i];
                    foreach (OrderDetails orderObj in particularOrder)
                    {
                        Console.WriteLine(
                            $"Item Name: {orderObj.Name}   Quantity: {orderObj.quantity}   Rate: {orderObj.rate}   Amount: {orderObj.rate * orderObj.quantity}"
                        );
                        grandTotal = orderObj.quantity * orderObj.rate + grandTotal;
                    }
                    Console.WriteLine("Your Final Total Bill amount is {0}", grandTotal);
                }
                i++;
            }

        }

    }

    internal class ShowAllOrders
    {
        public void ShowEveryOrders(List<List<OrderDetails>> ordersList)
        {

            foreach (List<OrderDetails> particularOrder in ordersList)
            {
                foreach (OrderDetails orderObj in particularOrder)
                {
                    Console.WriteLine(
                        $"Item Name: {orderObj.Name}   Quantity: {orderObj.quantity}   Rate: {orderObj.rate}   Amount: {orderObj.rate * orderObj.quantity}"
                    );
                }
            }
        }
    }
}
