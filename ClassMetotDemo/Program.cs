using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> list = new List<Customer>();
            Console.WriteLine("Welcome to bank interface..\nWhat is your need?");
            Console.WriteLine("'1' for list the customer list\n'2' for add customer to bank's database\n'3' for remove a customer from bank's database\n'0' for exit from interface");
            string s;
            int i;
            s = Console.ReadLine();
            i = Convert.ToInt32(s);
            CustomerManager customerManager= new CustomerManager();
            while (i != 0)
            {
                
                if (i == 1)
                {
                    customerManager.list_Customers(list);
                    
                }
                else if (i == 2)
                {
                    customerManager.add_Customer(list);
                    
                }
                else if(i == 3)
                {
                    customerManager.remove_Customer(list);
                }
                Console.WriteLine("\nWhat will be the next process");
                s = Console.ReadLine();
                i = Convert.ToInt32(s);
            }
        }
    }
    class Customer
    {
        public string Name;
        public string Surname;
        public string City;
        public string Address;
        public string PhoneNumber;
        public int Age;
        public int Id;
    }
    class CustomerManager
    {
        public void add_Customer(List<Customer> list) {
            Console.WriteLine("Please enter informations of new customer");
            Customer customer = new Customer();
            Console.WriteLine("Id: ");
            customer.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            customer.Surname = Console.ReadLine();
            Console.WriteLine("Age: ");
            customer.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("City: ");
            customer.City = Console.ReadLine();
            Console.WriteLine("Address: ");
            customer.Address = Console.ReadLine();
            Console.WriteLine("Phone Number: ");
            customer.PhoneNumber = Console.ReadLine();
            list.Add(customer);
            Console.WriteLine("\nCustomer added from database succesfully");
        }
        public void remove_Customer(List<Customer> list)
        {
            Customer customer = new Customer();
            Console.WriteLine("Please enter id of customer which will be removed");
            int counter = 1;
            foreach(var customers in list)
            {
                CustomerManager c= new CustomerManager();
                c.number_Of_Customer(counter++);
                Console.WriteLine("customer's id is "+customers.Id);
            }
            customer.Id = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i < list.Count; i++)
            {
                if (list[i].Id == customer.Id)
                {
                    list.RemoveAt(i);
                    Console.WriteLine("\nCustomer removed from database succesfully");
                }
            }
        }
        public void list_Customers(List<Customer> list){
            int i = 0;
            foreach (Customer customer in list)
            {
                CustomerManager customerManager = new CustomerManager();
                Console.WriteLine("\n");
                customerManager.number_Of_Customer(++i);
                Console.WriteLine("Customer's informations:");
                Console.WriteLine("Id: " + customer.Id + "\t" + "\t" + "Name: " +customer.Name+"\t" + "\t" + "Surame: " + customer.Surname+"\t"+ "Age: " + customer.Age);
                Console.WriteLine("City: " + customer.City + "\t" + "\t" + "Address: " + customer.Address + "\t" + "Phone Number: " + customer.PhoneNumber);
            }
        }
        private void number_Of_Customer(int i) { 
            if (i == 1)
                Console.Write( i+ "st ");

            else if(i== 2)
                Console.Write(i + "nd ");

            else if (i == 3)
                Console.Write(i + "rd ");

            else
                Console.Write(i + "th ");

        }
    }
}
