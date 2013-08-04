//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.TheFirmInfo
{
    class FirmInfo
    {
        static void Main()
        {
            Console.WriteLine("Type name of Company: ");
            string companyName = Console.ReadLine();
            Console.WriteLine("Type address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Type company phone number: ");
            int companyPhone = int.Parse(Console.ReadLine());
            Console.WriteLine("Type fax number: ");
            int fax = int.Parse(Console.ReadLine());
            Console.WriteLine("Type company web site: ");
            string webSite = Console.ReadLine();
            Console.WriteLine("Type The manager first name: ");
            string managerFName = Console.ReadLine();
            Console.WriteLine("Type The manager last name: ");
            string managerLName = Console.ReadLine();
            Console.WriteLine("Type The manager age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Type manager phone number: ");
            int managerPhone = int.Parse(Console.ReadLine());
            Console.WriteLine("The company {0} with address {1} \n phone number {2}, fax {3}, site {4}, \n {5} {6} - manager ,\n age - {8} \n phone {7} ", companyName, address, companyPhone, fax, webSite, managerFName, managerLName, age, managerPhone);
        }
    }
}
