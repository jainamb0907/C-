namespace Practical2
{
    internal class Customer_Account
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
            Console.WriteLine(
                "---------Customer Details---------\nBank Name: {0}\nCustomer Name: {1}\nCustomer Account Number: {2}",
                bank_name,
                customer_name,
                customer_accountNo
            );
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            // This would invoke parameterized constructor
            Customer_Account c_A = new Customer_Account("jainam", 1234);
            c_A.printInfo();
        }
    }
}
