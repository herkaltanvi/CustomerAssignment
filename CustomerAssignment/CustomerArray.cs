using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAssignment
{
    class CustomerArray
    {
        static int customer_id = 0;
        public Customer[] customer = new Customer[10];

        public void AddCustomerDetails(string name, string address, long phone_no, string city, string state, int pincode, string email_id)
        {
            
            customer[customer_id] = new Customer();
            customer[customer_id].CUSTOMER_ID = customer_id+1;
            customer[customer_id].NAME = name;
            customer[customer_id].ADDRESS = address;
            customer[customer_id].PHONE_NO = (int)phone_no;
            customer[customer_id].CITY = city;
            customer[customer_id].STATE = state;
            customer[customer_id].PINCODE = pincode;
            customer[customer_id].EMAIL_ID = email_id;
            Console.WriteLine($"Customer Added Successfully with Customer ID : {customer[customer_id].CUSTOMER_ID}");
            customer_id++;
        }

        public void ShowAllCustomerDetails()
        {
            for(int i = 0; i < 10; i++)
            {
                if(customer[i] == null)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("----------------------------------");

                        Console.WriteLine("No Customer added!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("----------------------------------");

                    Console.WriteLine($"Customer ID : {customer[i].CUSTOMER_ID}");
                    Console.WriteLine($"Name : {customer[i].NAME}");
                    Console.WriteLine($"Address : {customer[i].ADDRESS}");
                    Console.WriteLine($"Phone Number : {customer[i].PHONE_NO}");
                    Console.WriteLine($"City : {customer[i].CITY}");
                    Console.WriteLine($"State : {customer[i].STATE}");
                    Console.WriteLine($"Pincode : {customer[i].PINCODE}");
                    Console.WriteLine($"Email Id : {customer[i].EMAIL_ID}");
                }

            }
        }
        /*public void ShowCustomerDetailsByID(int id)
        {
            int flag = 0;
            for(int i = 0; i < 10; i++)
            {
                if (customer[i] == null)
                {
                    continue;
                }
                else
                {
                    if (customer[i].CUSTOMER_ID == id)
                    {
                        Console.WriteLine("----------------------------------");

                        Console.WriteLine($"Name : {customer[i].CUSTOMER_ID}");
                        Console.WriteLine($"Name : {customer[i].NAME}");
                        Console.WriteLine($"Address : {customer[i].ADDRESS}");
                        Console.WriteLine($"Phone Number : {customer[i].PHONE_NO}");
                        Console.WriteLine($"City : {customer[i].CITY}");
                        Console.WriteLine($"State : {customer[i].STATE}");
                        Console.WriteLine($"Pincode : {customer[i].PINCODE}");
                        Console.WriteLine($"Email Id : {customer[i].EMAIL_ID}");
                        flag = 1;
                        break;
                    }
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("----------------------------------");

                Console.WriteLine("ID not found!");
            }
        }*/

        public Customer this[int id]
        {
            get
            {
                return customer[id];
            }
            
        }
    }
}
