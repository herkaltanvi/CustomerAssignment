using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int pincode, choice = 0, id;
            long phone_no;
            string name, address, state, city, email_id;
            Console.WriteLine("# CUSTOMER DATABASE #");
            CustomerArray obj = new CustomerArray();
            while (choice != 4)
            {
                Console.WriteLine("----------------------------------");
                Console.Write("1. Add Customer\n2. Show all customers\n3. Search Customer by ID\n4. Exit\nEnter your option : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("----------------------------------");

                        Console.Write("Enter your full name : ");
                        name = Console.ReadLine();
                        Console.Write("Enter your address : ");
                        address = Console.ReadLine();
                        Console.Write("Enter your phone number : ");
                        phone_no = Convert.ToInt64(Console.ReadLine());
                        Console.Write("Enter your city : ");
                        city = Console.ReadLine();
                        Console.Write("Enter your state : ");
                        state = Console.ReadLine();
                        Console.Write("Enter your pincode : ");
                        pincode = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter your email id : ");
                        email_id = Console.ReadLine();

                        obj.AddCustomerDetails(name, address, phone_no, city, state, pincode, email_id);
                        break;
                    case 2:
                        obj.ShowAllCustomerDetails();

                        break;
                    case 3:
                        Console.WriteLine("----------------------------------");

                        Console.Write("Enter customer ID : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Customer c = obj[id-1];
                        Console.WriteLine(c.NAME);
                        Console.WriteLine(c.ADDRESS);
                        Console.WriteLine(c.PHONE_NO);
                        Console.WriteLine(c.CITY); 
                        Console.WriteLine(c.PINCODE);
                        Console.WriteLine(c.EMAIL_ID);
                        break;
                    case 4:

                        break;
                }
            }
        }
    }
}
