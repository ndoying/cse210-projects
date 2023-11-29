using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Customer customerInfo = new Customer();

        customerInfo.SetCustomerProperties("Akira Kurosawa"); 
        
        string customerName = customerInfo.GetName();

        Console.WriteLine(customerName);
        
        Address customerAddress = new Address();

        customerAddress.SetAddressProperties("13 Jonathan Avenue", "San Jose", "CA", "95118", "USA");

        string formattedAddress = customerAddress.GetFormattedAddress();

        Console.WriteLine(formattedAddress);
    }
}
        