namespace Practical2
{
    class Customer_Account
    {
        // data members of the class
        string bank_name = "HDFC";
        long customer_accountNo;
        string customer_name;

        // parameterized constructor would initialized data members with the values of passed arguments while object of that class created
        public Customer_Account(string customer_name, int customer_accountNo)
        {
            this.customer_name = customer_name;
            this.customer_accountNo = customer_accountNo;
        }

        // Instance method to print all the members of the Customer_Account
        public void printInfo()
        {
            Console.WriteLine("---------Customer Details---------");
            Console.WriteLine("Bank Name: " + bank_name);
            Console.WriteLine("Customer Name: " + customer_name);
            Console.WriteLine("Customer Account Number: " + customer_accountNo);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // This would invoke parameterized constructor
            Customer_Account c_A = new Customer_Account("jainam", 1234);
            c_A.printInfo();
        }
    }
}
