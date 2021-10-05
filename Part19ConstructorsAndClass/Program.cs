using System;

namespace Part19ConstructorsAndClass
{
    class Customer
    {
        string _FirstName;
        string _LastName;
        public Customer(string FirstName,string Lastname)
        {
            this._FirstName = FirstName;
            this._LastName = Lastname;

        }
        public void PrintFullName()
        {
            Console.WriteLine("Full name ={0} {1}",this._FirstName,this._LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lname = Console.ReadLine();
            Customer c = new Customer(fname,lname);
            c.PrintFullName();
        }
    }
}
