using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string firstname;
            string lastname;
            int age;
            string address;
            string email;
            int pin;

            Console.WriteLine("Please enter your firstname:  ");
            firstname = Console.ReadLine();
            Console.WriteLine("Please enter your lastname:  ");
            lastname = Console.ReadLine();
            Console.WriteLine("Please neter your age:  ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your address:  ");
            address = Console.ReadLine();
            Console.WriteLine("Please enter your email address");
            email = Console.ReadLine();
            Console.WriteLine("Please enter a PIN number:  ");
            pin = int.Parse(Console.ReadLine());







            //string concantination
            Console.WriteLine(firstname + " " + lastname + " " + age + " " + address + " " + email + " " + pin);

            //Replacement method
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", firstname, lastname, age, address, email, pin);

            //Dollar sign method
            Console.WriteLine($"{firstname} {lastname} {age} {address} {email} {pin}");

            Console.ReadLine();
        }
    }
}
